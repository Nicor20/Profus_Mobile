package crc647c4441a42b754995;


public class Montrer_Carte
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Profus_mobile.Montrer_Carte, Profus_mobile", Montrer_Carte.class, __md_methods);
	}


	public Montrer_Carte ()
	{
		super ();
		if (getClass () == Montrer_Carte.class)
			mono.android.TypeManager.Activate ("Profus_mobile.Montrer_Carte, Profus_mobile", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
