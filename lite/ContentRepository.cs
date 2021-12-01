using System;
using Kang.Core;

namespace Kang.Lite
{
    public class ContentRepository: IContentRepository
    {
        public void IterateChildNodes(IContentKey parentKey, Action<ContentNode> action)
        {
            var contentKey = ContentKey.OfNodeKey(parentKey);
            var childType = GetChildType(contentKey.Type);
            var commander = new NodeCommander();
            var command = commander.GetCommand($"{childType}.Select");
            var args = NodeCommandArgs.Builder.Create()
                .SetParentId(contentKey.Id)
                .Build();
            command.IterateNodes(args, action);
        }

        private ContentTypes GetChildType(ContentTypes parentType)
        {
            switch(parentType)
            {
                case ContentTypes.None: return ContentTypes.Family;
                case ContentTypes.Family: return ContentTypes.Brand;
                case ContentTypes.Brand: return ContentTypes.Episode;
                case ContentTypes.Episode: return ContentTypes.Media;
                default: return ContentTypes.None;
            }
        }
    }   
}