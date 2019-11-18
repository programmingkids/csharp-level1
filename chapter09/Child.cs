using System;

class Child : Parent
{
    public Child()
    {
        // 継承されたメンバ変数に値を代入する
        this.param1 = "this is child param1";
        // 継承されたメンバ変数に値を代入する
        this.param2 = "this is child param2";
        
        // 継承されていないので、利用するとエラーになります
        // this.param3 = "this is child param3";
    }
    
    public void showError()
    {
        // 継承されていないので、利用するとエラーになります
        // Console.WriteLine(this.param3);
    }
}
