﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCode.WordsConverter
{
    public class CamelCaseConverter : IWordsConverter
    {
        public bool Initialized { get; private set; }

        public string Name => "Camel";

        public String Convert(IEnumerable<string> words)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool isFirstWord = true;
            foreach (var word in words)
            {
                string firstChar = word.Substring(0, 1).ToUpper();
                if (isFirstWord) { firstChar = firstChar.ToLower(); }
                stringBuilder.Append(firstChar);
                string leftChar = word.Substring(1).ToLower();
                stringBuilder.Append(leftChar);
            }
            return stringBuilder.ToString();
        }

        public void Initialize(IDictionary<string, object> paramters)
        {
            Initialized = true;
        }
    }
}
