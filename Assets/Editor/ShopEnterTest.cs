using UnityEngine;
using UnityEditor;
using NUnit.Framework;

[TestFixture]
public class ShopEnterTest {

    [Test]
    public void EnterTest()
    {
		Debug.Log ("Enter Shop Test");
		var shop = new Shop();
		shop.gotoshopOnTest();
		Assert.AreEqual(shop.getLevelOnTest(), "Assets/inshop.unity");
    }

	[Test]
	public void ExitTest()
	{
		Debug.Log ("Exit Shop Test");
		var shop = new Shop();
		shop.gotoshoppingmallOnTest ();
		Assert.AreEqual(shop.getLevelOnTest(), "Assets/Shoppingmall.unity");
	}
}
