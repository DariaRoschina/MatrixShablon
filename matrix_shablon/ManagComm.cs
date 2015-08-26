using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
   class ManagComm
    {
      
    static  private  ManagComm instance = new ManagComm(); //статическая переменная, для хранения единственного экземпляра, сразу создаем объект
      private ManagComm() { } // закрытый конструктор, т.к только он может создавать экземпляры этого класса
     static public  ManagComm getInstance() //метод создает и возвращает экземпляр 
      {
          if (instance == null) //если содержит 0, то экземпляр еще не создан
          { instance = new ManagComm(); }
          return instance;
        }
           List<ICommand> commands = new List<ICommand>();
    
      public void addComm(ICommand com)
      {
          foreach (ICommand i in commands)
          {
            commands.Add(com);
              
           }
      }

      public void remComm()
      {
          if (commands.Count != 1)
          {
              commands.RemoveAt(commands.Count - 1);
              foreach (ICommand i in commands)
              { i.Execute(); }
            
          }
      }
  
  
  }
}
