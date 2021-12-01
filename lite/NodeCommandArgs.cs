namespace Kang.Lite
{
    class NodeCommandArgs
    {
        public long ParentId { get; private set; }

        public class Builder
        {
            public static Builder Create() => new Builder();

            public NodeCommandArgs Build() => _args;
            public Builder SetParentId(long value) { _args.ParentId = value; return this; }
            private Builder() {}

            private NodeCommandArgs _args = new NodeCommandArgs();
        }

        private NodeCommandArgs() {}
    }
}