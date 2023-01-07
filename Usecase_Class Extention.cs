// custom extention for string type
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
// 1
namespace CustomExtensions 
{   
// 2   
  public static class StringExtensions
  {       
      // 3      
      public static void FancyDebug(this string str) 
      {           
          // 4          
          Debug.LogFormat("This string contains {0} characters.",str.Length);
      } 
   }
}

// **************************


// 1
using CustomExtensions;


public void Initialize(){       
    _state = "Manager initialized..";        
    // 2       
    _state.FancyDebug();
    Debug.Log(_state);    
}
