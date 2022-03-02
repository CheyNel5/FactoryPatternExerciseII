using System.Collections.Generic;

namespace FactoryPatternII
{
    public interface IDataAccess
    {
        List<Product> LoadData();
        void SaveData();
    }
}
