using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Client
    {

        public int number;
        private int _code;
        public string _name;
        private string _email;
        private string _tel;
        private string _dateBd;
        public ClientType _tpy;

        public Client()
        {

        }
        public int Code
        {
            set { _code = value; }
            get { return _code; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        public string DateBd
        {
            set { _dateBd = value; }
            get { return _dateBd; }
        }
        public void IsYourType(string typeClient)
        {
            ClientType[] arr = ClientType.addClient();
            _tpy = new ClientType();

            foreach (ClientType i in arr)
            {
                if (i.Type == typeClient)
                {
                    _tpy = i;
                }
            }

        }

        public void SetFileds()
        {
            Code = Convert.ToInt32(Clients.dataClients[0, number].Value);
            Name = (String)Clients.dataClients[1, number].Value; ;
            Email = (String)Clients.dataClients[2, number].Value;
            Tel = (String)Clients.dataClients[3, number].Value;
            DateBd = (String)Clients.dataClients[4, number].Value;
            IsYourType((String)Clients.dataClients[5, number].Value);

        }
    }
}
