﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNLP.Tools.Util.Ling
{
    /// <summary>
    /// @author grenager
    /// 
    /// Code...
    /// </summary>
    public interface IHasContext
    {
        /// <summary>
        /// Returns the string before the word
        /// </summary>
        string Before();

        /// <summary>
        /// Set the whitespace string before the word.
        /// </summary>
        void SetBefore(string before);

        /// <summary>
        /// Returns the string which is the original character sequence of the token.
        /// </summary>
        string OriginalText();

        /// <summary>
        /// Set the string which is the original character sequence of the token.
        /// </summary>
        void SetOriginalText(string originalText);

        /// <summary>
        /// Returns the whitespace string after the word.
        /// </summary>
        string After();

        /// <summary>
        /// Sets the whitespace string after the word.
        /// </summary>
        void SetAfter(string after);

    }
}