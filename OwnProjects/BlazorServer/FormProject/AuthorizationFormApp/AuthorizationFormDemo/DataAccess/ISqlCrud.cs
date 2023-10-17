using AuthorizationFormDemo.Models;
using System.Threading.Channels;

namespace AuthorizationFormDemo.DataAccess
{
    public interface ISqlCrud
    {
        public List<Agency> GetAgencies();
        public List<ChannelModel> GetChanneles();
        public Agency GetUserById(int id);

    }
}
