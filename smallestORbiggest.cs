
    // March 22 -2021 (14 years now)
    // Project : Find smallest or biggest number
    
using System;
class HelloWorld {
  static void Main() {
    int[] comparenums={9,4,2,6,9,7};
    
    Console.WriteLine("Smallest number: "+fSb_Num(comparenums,true));
    Console.WriteLine("Biggest number: "+fSb_Num(comparenums,false));
    
  }
  
  static int fSb_Num(int[] nums,bool f_smallest){ // find smallest or biggest number;
      int topnum;
      topnum=nums[0];
      for(int i=0;i<nums.Length;i++){
          if(f_smallest){
              if(nums[i]<topnum){
                  topnum=nums[i];
              }
          }else{
              if(nums[i]>topnum){
                  topnum=nums[i];
              }
          }
      }
      
      return topnum;
  }
  
}
