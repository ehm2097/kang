using System;
using System.Collections.Generic;

namespace Kang.Core
{
    public interface IContentRepository
    {
        // ContentNode GetRootNode();
        void IterateChildNodes(IContentKey parentKey, Action<ContentNode> action);

        // ContentNode AppendNode(ContentNode node, IContentKey parentId);
        // void InsertNode(ContentNode node, ContentNode parentNode, ContentNode beforeNode);

        // void DeleteNode(IContentKey nodeId);

        // void MoveNode(ContentNode node, ContentNode parentNode);
        // void MoveNode(ContentNode node, ContentNode parentNode, ContentNode beforeNode);

        // IEnumerable<INamedToken> RatingCategories { get; }
        // int GetRating(IContentKey nodeId, INamedToken ratingCategory);
        // void SetRating(IContentKey nodeId, INamedToken ratingCategory, int rating);

        // ITagCategory GlobalTagCategory { get; }
        // IEnumerable<INamedToken> GetTags(IContentKey nodeId);
        // void AddTag(IContentKey nodeId, INamedToken tag);
        // void RemoveTag(IContentKey nodeId, INamedToken tag);
    }
}