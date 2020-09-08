using System;
using FirstLib;
using Xunit;

namespace FirstcoreProject {

   public class test {
 
   [Fact]
   public void TestName()
   {
     var obj=new Addition();
     Assert.Equal("ok",obj.display());
      
   }


    

   }


}












