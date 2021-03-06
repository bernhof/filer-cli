﻿using CommandLine;
using System.Collections.Generic;

namespace Filer.Cli.Verbs
{
    [Verb("concat", HelpText = "Concatenates multiple text files into one")]
    class ConcatVerb : OutVerb
    {
        /// <summary>
        /// Glob patterns the specify which files to include
        /// </summary>
        [Value(0, HelpText = "Glob patterns that specify image files whose dates should be shifted. Prefix a pattern with ! to exclude files.", Required = true)]
        public IEnumerable<string> GlobPatterns { get; set; }

        /// <summary>
        /// Separator to include between file contents
        /// </summary>
        [Option('s', "sep", Required = false, Default = "\n", HelpText = "Separator to include between contents of each file. Use \\n for newline. Default separator is \\n.")]
        public string Separator { get; set; } = "\n";

        /// <summary>
        /// Header to include before each file
        /// </summary>
        [Option('h', "header", Required = false, Default = "", HelpText = "Header to include before contents of each file. Use \\n for newline, {0} for file name, {1} for path and file name, escape { with {{.")]
        public string Header { get; set; }
    }
}
