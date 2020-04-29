package unity_aanp.testjar;

import java.util.Collections;
import java.util.List;

public class SimpleClass {
    public int simpleField = 11;
    public static int staticField = 12;
    public List<Integer> simpleListField = Collections.singletonList(13);
    public List<int[]> nestedListField = Collections.singletonList(new int[] { 14 });
    public List<String> complexListField = Collections.singletonList("s15");

    public void simpleVoidMethod() {
        System.out.println("simpleVoidMethod");
    }

    private void hiddenMethod() {
    }

    public static int staticMethod() {
        return 21;
    }

    public String simpleArgsMethod(int a, String b, List<String> c) {
        return String.format("simpleArgsMethod: %d, %s, %s\n", a, b, c);
    }
}
