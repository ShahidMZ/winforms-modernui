/**
 * MetroFramework - Modern UI for WinForms
 * 
 * The MIT License (MIT)
 * Copyright (c) 2011 Sven Walter, http://github.com/viperneo
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation the rights to use, copy, 
 * modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
 * and to permit persons to whom the Software is furnished to do so, subject to the 
 * following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in 
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
 * CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System.Drawing;

namespace MetroFramework
{
    public sealed class MetroColors
    {
        public static Color Black
        {
            get
            {
                return Color.FromArgb(0, 0, 0);
            }
        }

        public static Color White
        {
            get
            {
                return Color.FromArgb(255, 255, 255);
            }
        }

        public static Color Silver
        {
            get
            {
                return Color.FromArgb(85, 85, 85);
            }
        }

        public static Color Blue
        {
            get
            {
                return System.Drawing.ColorTranslator.FromHtml("#0099FF");
            }
        }

        public static Color LightGreen
        {
            get
            {
                return System.Drawing.ColorTranslator.FromHtml("#00FF00");
            }
        }

        public static Color DarkGreen
        {
            get
            {
                return System.Drawing.ColorTranslator.FromHtml("#00FF00");
            }
        }

        public static Color Lime
        {
            get
            {
                return Color.FromArgb(142, 188, 0);
            }
        }

        public static Color Teal
        {
            get
            {
                return Color.FromArgb(0, 170, 173);
            }
        }

        public static Color Orange
        {
            get
            {
                return System.Drawing.ColorTranslator.FromHtml("#FF9900");
            }
        }

        public static Color Brown
        {
            get
            {
                return System.Drawing.ColorTranslator.FromHtml("#663300");
            }
        }

        public static Color Pink
        {
            get
            {
                return Color.FromArgb(231, 113, 189);
            }
        }

        public static Color Magenta
        {
            get
            {
                return Color.FromArgb(255, 0, 148);
            }
        }

        public static Color Purple
        {
            get
            {
                return Color.FromArgb(124, 65, 153);
            }
        }

        public static Color Red
        {
            get
            {
                return System.Drawing.ColorTranslator.FromHtml("#E71121");
            }
        }

        public static Color Yellow
        {
            get
            {
                return System.Drawing.ColorTranslator.FromHtml("#FFFF00");
            }
        }
    }
}
