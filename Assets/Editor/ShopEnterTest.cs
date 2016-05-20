using UnityEngine;
using UnityEditor;
using NUnit.Framework;

[TestFixture]
public class ShopEnterTest {

	/**
	 * 	Try to enter inshop scene with function directly
	 * 	and then assert that player is in shop.
	 **/
    [Test]
    public void EnterTest()
    {
		Debug.Log ("Enter Shop Test");
		var shop = new Shop();
		shop.gotoshopOnTest();
		Assert.AreEqual(shop.getLevelOnTest(), "Assets/inshop.unity");
    }

	/**
	 *	Try to exit inshop scene with function directly
	 *	and then assert that player is went to mall.
	 * 
	 **/
	[Test]
	public void ExitTest()
	{
		Debug.Log ("Exit Shop Test");
		var shop = new Shop();
		shop.gotoshoppingmallOnTest ();
		Assert.AreEqual(shop.getLevelOnTest(), "Assets/Shoppingmall.unity");
	}
}
