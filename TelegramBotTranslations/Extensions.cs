﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;

namespace TelegramBotTranslations
{
    internal static class Extensions
    {
        public static string ToBold(this string str, ParseMode parseMode)
        {
            switch (parseMode)
            {
                case ParseMode.Markdown:
                    return $"*{str}*";

                case ParseMode.Html:
                    return $"<b>{str}</b>";

                case ParseMode.Default:
                default:
                    return str;
            }
        }

        public static string ToItalic(this string str, ParseMode parseMode)
        {
            switch (parseMode)
            {
                case ParseMode.Markdown:
                    return $"_{str.FormatMarkdown()}_";

                case ParseMode.Html:
                    return $"<i>{str.FormatHTML()}</i>";

                case ParseMode.Default:
                default:
                    return str;
            }
        }

        public static string FormatMarkdown(this string str)
        {
            return str.Replace("_", "\\_").Replace("*", "\\*").Replace("[", "\\[");
        }

        public static string FormatHTML(this string str)
        {
            return str.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");
        }
    }
}
