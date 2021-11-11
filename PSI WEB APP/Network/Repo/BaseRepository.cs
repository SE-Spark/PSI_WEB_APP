using Newtonsoft.Json;
using PSI_WEB_APP.Network.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PSI_WEB_APP.Network
{
    public class BaseRepository<TEntity > : IBase<TEntity> where TEntity : class 
    {
        HttpClient _client;
        String END_POINT;
        public BaseRepository(String END_POINT)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Constants.BASE_URL);
            this.END_POINT = END_POINT;
        }
        public void delete(TEntity T)
        {
            var url = Constants.BASE_URL +END_POINT+ Constants.URL_DELETE;
            HttpResponseMessage res = _client.DeleteAsync(url + T).Result;
        }

        public void delete(object id)
        {
            var url = Constants.BASE_URL + END_POINT + Constants.URL_DELETE;
            HttpResponseMessage res = _client.DeleteAsync(url + id).Result;
        }

        public List<TEntity> get()
        {
            var url = Constants.BASE_URL + END_POINT;
            var list = new List<TEntity>();
            HttpResponseMessage res = _client.GetAsync(url).Result;
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                list = JsonConvert.DeserializeObject<List<TEntity>>(results);
            }
            return list;
        }

        public TEntity get(object id)
        {
            var url = Constants.BASE_URL + END_POINT;
            TEntity item = null;
            HttpResponseMessage res = _client.GetAsync(url+id).Result;
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                 item = JsonConvert.DeserializeObject<TEntity>(results);
            }
            return item;
        }

        public void insert(TEntity T)
        {
            var url = Constants.BASE_URL + END_POINT + Constants.URL_INSERT;
            string data = JsonConvert.SerializeObject(T);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync(url, content).Result;
        }

        public void update(TEntity T)
        {
            var url = Constants.BASE_URL + END_POINT + Constants.URL_UPDATE;
            string data = JsonConvert.SerializeObject(T);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PutAsync(url, content).Result;
        }
    }
}
