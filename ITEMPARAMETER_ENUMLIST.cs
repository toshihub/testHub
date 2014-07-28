namespace ITEM
{
    public enum CLASS  //ITEM自体の価値
    {
        NONE = 0,
        LOWER,          //低い
        SEMI_LOWER,     //MIDDLEより低くLOWERより高い
        MIDDLE,         //中間
        SEMI_HIGHER,    //MIDDLEより高くHIGHERより低い
        HIGHER,         //高い
    }

    public enum TYPE    //ITEM自体の種類
    {
        NONE = 0,
        SWORD,          //剣
        SHIELD,         //盾
        POTION,         //ポーション
        ARMOR,          //アーマー
        
    }
}
