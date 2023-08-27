



using Core.Domain.Menu;
using Core.Interface;
using Infrastructure.Data.Context;
using Infrastructure.Data.Entities;

namespace Infrastructure.Repository.Menu;

public class Menu : IMenu
{
    private readonly Context dbContext;
    public Menu(Context _dbContext)
    {
        dbContext=_dbContext;
    }
    public void Add(ModelMenu modelMenu)
    { 
          var tbl_Menu=new Tbl_Menu();
          tbl_Menu.CatName=modelMenu.CatName;
          tbl_Menu.ParentId=modelMenu.ParentId;
          tbl_Menu.Status=modelMenu.Status;
          dbContext.Add(tbl_Menu);
          dbContext.SaveChanges();
    }

    public List<ModelMenu> GetAllMenus()
    {
        var menus=dbContext.Tbl_Menus.ToList();
        var modelMenus=new List<ModelMenu>();
        foreach (var menu in menus)
        {
            var modelMenu=new ModelMenu();
            modelMenu.Id=menu.Id;
            modelMenu.CatName=menu.CatName;
            modelMenu.ParentId=menu.ParentId;
            modelMenus.Add(modelMenu);
        }
        return modelMenus.OrderByDescending(x => x.Id).ToList();
    }

    public string GetParentNameById(int parentId)
    {
        if(parentId == 0){
            return "Main Category";
        }
        else{
            var menu=dbContext.Tbl_Menus.Find(parentId);
            if(menu!=null)
            return menu.CatName;
            else
            return "Invalid ParentName";
        }
        
    }

    
}

