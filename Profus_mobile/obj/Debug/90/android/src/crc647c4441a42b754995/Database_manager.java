package crc647c4441a42b754995;


public class Database_manager
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Profus_mobile.Database_manager, Profus_mobile", Database_manager.class, __md_methods);
	}


	public Database_manager ()
	{
		super ();
		if (getClass () == Database_manager.class)
			mono.android.TypeManager.Activate ("Profus_mobile.Database_manager, Profus_mobile", "", this, new java.lang.Object[] {  });
	}

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
