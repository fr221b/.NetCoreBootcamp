
using Core.Domain.Menu;

namespace Core.Interface;

public interface IMenu
{
    void Add(ModelMenu modelMenu);
    List<ModelMenu> GetAllMenus();
    string GetParentNameById(int parentId);
    
}