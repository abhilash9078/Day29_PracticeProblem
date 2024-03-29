﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyser.POCO
{
    /// <summary>
    /// Custom Exception class
    /// </summary>
    public class CensusAnalyserException :Exception
    {
        /// <summary>
        /// Enum for Custom exception type 
        /// </summary>
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_DELIMITER, INCORRECT_HEADER , NO_SUCH_COUNTRY
        }
        public ExceptionType eType;
        public CensusAnalyserException(string message, ExceptionType exceptionType) : base(message)
        {
            this.eType = exceptionType;
        }
    }
}
