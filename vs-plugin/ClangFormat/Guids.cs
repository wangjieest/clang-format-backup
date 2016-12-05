using System;

namespace LLVM.ClangFormat
{
    static class GuidList
    {
        public const string guidClangFormatPkgString = "c5286038-25d3-4f65-83a8-51fa2df4a146";
        public const string guidClangFormatCmdSetString = "e39cbab1-0f96-4022-a2bc-da5a9db7eb78";
        public const string guidClangFormatCmdFullString = "39D68D1E-1C53-4D0B-AE4B-A02BABEB3A4C";

        public static readonly Guid guidClangFormatCmdSet = new Guid(guidClangFormatCmdSetString);
        public static readonly Guid guidClangFormatCmdFull = new Guid(guidClangFormatCmdFullString);
    };
}