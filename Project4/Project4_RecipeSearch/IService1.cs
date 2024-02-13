using System.ServiceModel;

namespace Project4_RecipeSearch
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string FindRecipes(string ingredients);
    }
}
