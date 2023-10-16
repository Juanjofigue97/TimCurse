namespace AuthorizationFormDemo.Services
{
    public interface ISendSMS
    {
        public (bool status, int code) Send(string celular);
        public (bool status, int code) SendTest(string celular);
    }
}
