using System;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using zissou.Models;

namespace zissou
{
    public class CacheManager<T> : ICacheManager<T> where T : class
    {  
        private RedisManagerPool _redisManager = new RedisManagerPool("192.168.99.100:32768");
        private IRedisClient _redis;
        private IRedisTypedClient<T> _entity;

        public CacheManager()
        {
			_redis = _redisManager.GetClient();
            _entity = _redis.As<T>();
        }

        public void DeleteKey(string id) {
            _entity.DeleteById(id);
        }

        public T GetKey(string id)
        {
            return _entity.GetById(id);
        }

        public void StoreKey(T item)
        {
            _entity.Store(item);
        }
    }

    public interface ICacheManager<T> {
        T GetKey (string id);
        void StoreKey(T item);
        void DeleteKey(string id);
    }
}
