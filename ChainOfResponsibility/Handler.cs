namespace ChainOfResponsibility
{
    abstract class Handler
    {
        protected Handler next;

        public void SetHandler(Handler next)
        {
            this.next = next;
        }

        abstract public void HandleRequest(int request);
    }
}