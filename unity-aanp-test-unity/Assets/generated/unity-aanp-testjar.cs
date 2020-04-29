namespace unity_aanp.testjar
{
public class SimpleClass
{
    private static UnityEngine.AndroidJavaClass _javaClass;
    private UnityEngine.AndroidJavaObject _javaObject;

    static SimpleClass()
    {
        _javaClass = new UnityEngine.AndroidJavaClass("unity_aanp.testjar.SimpleClass");
    }

    public SimpleClass()
    {
        _javaObject = new UnityEngine.AndroidJavaObject("unity_aanp.testjar.SimpleClass");
    }

    // I
    public int simpleField
    {
        get { return _javaObject.Get<int>("simpleField"); }
    }

    // I
    public static int staticField
    {
        get { return _javaClass.GetStatic<int>("staticField"); }
    }

    // Ljava/util/List;
    public UnityEngine.AndroidJavaObject simpleListField
    {
        get { return _javaObject.Get<UnityEngine.AndroidJavaObject>("simpleListField"); }
    }

    // Ljava/util/List;
    public UnityEngine.AndroidJavaObject nestedListField
    {
        get { return _javaObject.Get<UnityEngine.AndroidJavaObject>("nestedListField"); }
    }

    // Ljava/util/List;
    public UnityEngine.AndroidJavaObject complexListField
    {
        get { return _javaObject.Get<UnityEngine.AndroidJavaObject>("complexListField"); }
    }

    // ()I
    public static int staticMethod()
    {
        return _javaClass.CallStatic<int>("staticMethod", new object[]{});
    }

    // (ILjava/lang/String;Ljava/util/List;)Ljava/lang/String;
    public string simpleArgsMethod(int param0, string param1, UnityEngine.AndroidJavaObject param2)
    {
        return _javaObject.Call<string>("simpleArgsMethod", new object[]{param0, param1, param2});
    }

    // ()V
    public void simpleVoidMethod()
    {
        _javaObject.Call("simpleVoidMethod", new object[]{});
    }
}
}
