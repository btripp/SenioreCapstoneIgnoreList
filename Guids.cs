// Guids.cs
// MUST match guids.h
using System;

namespace AugustaStateUniversity.SeniorCapstoneIgnoreList
{
    static class GuidList
    {
        public const string guidSeniorCapstoneIgnoreListPkgString = "4b3d1ac0-b4ef-4ae4-bcd2-7eb2c7a82c94";
        public const string guidSeniorCapstoneIgnoreListCmdSetString = "89b2f6e4-8338-484c-a64a-1ef024a4621c";
        public const string guidToolWindowPersistanceString = "7cffc514-66b4-442a-8fef-ec38f11a1c75";

        public static readonly Guid guidSeniorCapstoneIgnoreListCmdSet = new Guid(guidSeniorCapstoneIgnoreListCmdSetString);
    };
}