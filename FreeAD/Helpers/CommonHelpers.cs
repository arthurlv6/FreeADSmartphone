﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeAD.Helpers
{
    public static class CommonHelpers
    {
        public static int IndexOfOccurence(this string s, string match, int occurence)
        {
            int i = 1;
            int index = 0;

            while (i <= occurence && (index = s.IndexOf(match, index + 1)) != -1)
            {
                if (i == occurence)
                    return index;

                i++;
            }

            return -1;
        }
    }
}