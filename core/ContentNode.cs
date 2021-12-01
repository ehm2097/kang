namespace Kang.Core
{

    public class ContentNode
    {
        public IContentKey Key { get; private set; }
        public string Title { get; private set; }
        public byte[] Thumbnail { get; private set; }

        public class Builder
        {
            public Builder SetKey(IContentKey value) { _target.Key = value; return this; }
            public Builder SetTitle(string value) { _target.Title = value; return this; }
            public Builder SetThumbnail(byte[] value) { _target.Thumbnail = value; return this; }

            public ContentNode Build() => _target;

            public static Builder Create() => new Builder(null);
            public static Builder Create(ContentNode sourceNode) => new Builder(sourceNode);

            private Builder(ContentNode sourceNode) 
            {
                if(sourceNode != null)
                {
                    SetKey(sourceNode.Key);
                    SetTitle(sourceNode.Title);
                    SetThumbnail(sourceNode.Thumbnail);
                }
            }

            private ContentNode _target = new ContentNode();
        }

        public override bool Equals(object obj)
        {
            var otherNode = obj as ContentNode;
            return otherNode == null ? false : otherNode.Key.Equals(Key);
        }

        public override int GetHashCode()
        {
            return Key == null ? 0 : Key.GetHashCode();
        }

        public override string ToString()
        {
            return $"[{Key}]: {Title}";
        }

        private ContentNode() { }
    }
}