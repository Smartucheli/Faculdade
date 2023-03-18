
static int FunRec1(int a){
    if(a <= 1){
        return 0;
    } else {
        return FunRec1(a-2) + 5;
    }
}

Console.Write(FunRec1(10));

