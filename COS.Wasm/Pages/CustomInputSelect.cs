using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

// Created CustomInputSelect as .NET default does not accept int.

namespace COS.Wasm.Pages
{
    public class CustomInputSelect<TValue> : InputSelect<TValue>
    {
        protected override bool TryParseValueFromString(string value, out TValue result, out string validationErrorMessage)
        {
            if(typeof(TValue) == typeof(int))
            {
                if(int.TryParse(value, out var resultInt))
                {
                    result = (TValue)(object)resultInt;
                    validationErrorMessage = null;
                    return true;
                }
                else
                {
                    result = default;
                    validationErrorMessage = $"The Selected value {value} is not a valid number.";
                    return false;
                }
            }
            else
            {
                return base.TryParseValueFromString(value, out result, out validationErrorMessage);
            }
        }
    }
}