using unity_aanp.testjar;
using UnityEngine;

public class TestButtons : MonoBehaviour
{
    private SimpleClass inst;

    public float DesignWidth = 400;
    public float DesignHeight = 300;
    private void Start()
    {
        inst = new SimpleClass();
    }

    private void OnGUI()
    {
        float resX = (float)(Screen.width) / DesignWidth;
        float resY = (float)(Screen.height) / DesignHeight;
        float scale = Mathf.Max(resX, resY);
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(scale, scale, 1));

        if (GUILayout.Button(nameof(SimpleClass.simpleField))) print(inst.simpleField);
        if (GUILayout.Button(nameof(SimpleClass.staticField))) print(SimpleClass.staticField);
        if (GUILayout.Button(nameof(SimpleClass.simpleListField))) print(inst.simpleListField);
        if (GUILayout.Button(nameof(SimpleClass.nestedListField))) print(inst.nestedListField);
        if (GUILayout.Button(nameof(SimpleClass.complexListField))) print(inst.complexListField);

        if (GUILayout.Button(nameof(SimpleClass.simpleVoidMethod))) inst.simpleVoidMethod();
        if (GUILayout.Button(nameof(SimpleClass.staticMethod))) print(SimpleClass.staticMethod());
        if (GUILayout.Button(nameof(SimpleClass.simpleArgsMethod))) print(inst.simpleArgsMethod(111, "s112", null));
    }
}
