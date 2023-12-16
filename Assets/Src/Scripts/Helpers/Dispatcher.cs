using System;

public static class Dispatcher {
    public static event EventHandler DateChanged;
    
    public static void DispatchDateChanged(object sender, CustomArgs.DateChangedArgs e) {
        DateChanged.Invoke(sender, e);
    }
}
