using Kang.Core;

namespace Kang.Lite
{
    class ContentKey: IContentKey
    {
        public static ContentKey OfNodeKey(IContentKey key)
        {
            if (key == null) return ContentKey.Empty;
            else return (ContentKey) key;
        }

        public static ContentKey OfNode(ContentNode node)
        {
            if (node == null) return ContentKey.Empty;
            else return OfNodeKey(node.Key);
        }

        public ContentKey(ContentTypes type, long id)
        {
            _type = type;
            _id = id;
        }

        public static ContentKey Empty => _empty;

        public ContentTypes Type => _type;
        public long Id => _id;

        public override string ToString() => _id == 0 ? $"{_type}" : $"{_type}{_id:000000000000}";

        public override bool Equals(object obj)
        {
            var otherKey = obj as ContentKey;
            if(otherKey == null) return false;
            if(otherKey.Type != _type) return false;
            if(otherKey.Id != _id) return false;
            return true;
        }

        public override int GetHashCode() => ToString().GetHashCode();

        private static ContentKey _empty = new ContentKey(ContentTypes.None, 0);

        private ContentTypes _type;
        private long _id;
    }
}