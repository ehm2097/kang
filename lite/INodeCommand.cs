using System;
using Kang.Core;

namespace Kang.Lite
{
    interface INodeCommand
    {
        void IterateNodes(NodeCommandArgs args, Action<ContentNode> action);   
    }
}