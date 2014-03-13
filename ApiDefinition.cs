using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.StoreKit;

namespace BBlockLibrary
{
	public delegate void NSObjectBBlock (NSString keyPath, NSObject obj, NSDictionary change);
	public delegate void SKStoreProductViewControllerBBlock (SKProductsResponse response, NSError error);
	public delegate void UIActionSheetBBlock (int buttonIndex, UIActionSheet actionSheet);
	public delegate void UIAlertViewBBlock (int buttonIndex, UIAlertView alertView);
	public delegate void BBlockUIControlBlock (NSObject control, UIEvent evt);
	public delegate void UIGestureRecognizerBBlock (NSObject gestureRecognizer);
	public delegate void UITextFieldShouldReturnBBlock (UITextField textField);
	public delegate void BBlockBlock ();

	[BaseType (typeof (NSObject))]
	public partial interface BBlock
	{
		[Export ("test:")]
		string test (string test);

		[Static, Export ("dispatchOnMainThread:")]
		void DispatchOnMainThread (BBlockBlock block);

		[Static, Export ("dispatchAfter:onMainThread:")]
		void DispatchAfter (double delay, BBlockBlock block);

		[Static, Export ("dispatchOnSynchronousQueue:")]
		void DispatchOnSynchronousQueue (BBlockBlock block);

		[Static, Export ("dispatchOnSynchronousFileQueue:")]
		void DispatchOnSynchronousFileQueue (BBlockBlock block);

		[Static, Export ("dispatchOnDefaultPriorityConcurrentQueue:")]
		void DispatchOnDefaultPriorityConcurrentQueue (BBlockBlock block);

		[Static, Export ("dispatchOnLowPriorityConcurrentQueue:")]
		void DispatchOnLowPriorityConcurrentQueue (BBlockBlock block);

		[Static, Export ("dispatchOnHighPriorityConcurrentQueue:")]
		void DispatchOnHighPriorityConcurrentQueue (BBlockBlock block);

		// UIImage helper methods
		[Static, Export ("imageForSize:withDrawingBlock:")]
		UIImage ImageForSize (SizeF size, BBlockBlock drawingBlock);

		[Static, Export ("imageForSize:opaque:withDrawingBlock:")]
		UIImage ImageForSize (SizeF size, bool opaque, BBlockBlock drawingBlock);

		[Static, Export ("imageWithIdentifier:forSize:andDrawingBlock:")]
		UIImage ImageWithIdentifier (string identifier, SizeF size, BBlockBlock drawingBlock);

		[Static, Export ("imageWithIdentifier:opaque:forSize:andDrawingBlock:")]
		UIImage ImageWithIdentifier (string identifier, bool opaque, SizeF size, BBlockBlock drawingBlock);

		[Static, Export ("imageWithIdentifier:")]
		UIImage ImageWithIdentifier (string identifier);

		[Static, Export ("removeImageWithIdentifier:")]
		void RemoveImageWithIdentifier (string identifier);

		[Static, Export ("removeAllImages")]
		void RemoveAllImages ();
	}

	[Category, BaseType (typeof (NSArray))]
	public partial interface BBlock_NSArray
	{
		[Export ("enumerateEachObjectUsingBlock:")]
		void EnumerateEachObjectUsingBlock (BBlockBlock block);

		[Export ("arrayWithObjectsMappedWithBlock:")]
		NSObject [] ArrayWithObjectsMappedWithBlock (BBlockBlock block);
	}

	[Category, BaseType (typeof (NSDictionary))]
	public partial interface BBlock_NSDictionary
	{
		[Export ("enumerateEachKeyAndObjectUsingBlock:")]
		void EnumerateEachKeyAndObjectUsingBlock (BBlockBlock block);

		[Export ("enumerateEachSortedKeyAndObjectUsingBlock:")]
		void EnumerateEachSortedKeyAndObjectUsingBlock (BBlockBlock block);
	}

	[Category, BaseType (typeof (NSObject))]
	public partial interface BBlock_NSObject
	{
		[Export ("addObserverForKeyPath:options:block:")]
		string AddObserverForKeyPath (string keyPath, NSKeyValueObservingOptions options, NSObjectBBlock block);

		[Export ("removeObserverForToken:")]
		void RemoveObserverForToken (string identifier);

		[Export ("removeObserverBlocksForKeyPath:")]
		void RemoveObserverBlocksForKeyPath (string keyPath);

		[Export ("changeValueWithKey:changeBlock:")]
		void ChangeValueWithKey (string key, BBlockBlock changeBlock);
	}

	[Category, BaseType (typeof (NSTimer))]
	public partial interface BBlock_NSTimer
	{
		[Static, Export ("timerWithTimeInterval:andBlock:")]
		NSTimer TimerWithTimeInterval (double timeInterval, BBlockBlock block);

		[Static, Export ("timerRepeats:withTimeInterval:andBlock:")]
		NSTimer TimerRepeats (bool repeats, double timeInterval, BBlockBlock block);

		[Static, Export ("scheduledTimerWithTimeInterval:andBlock:")]
		NSTimer ScheduledTimerWithTimeInterval (double timeInterval, BBlockBlock block);

		[Static, Export ("scheduledTimerRepeats:withTimeInterval:andBlock:")]
		NSTimer ScheduledTimerRepeats (bool repeats, double timeInterval, BBlockBlock block);
	}

	[Category, BaseType (typeof (UIControl))]
	public partial interface BBlock_UIControl
	{
		[Export ("addActionForControlEvents:withBlock:")]
		void AddActionForControlEvents (UIControlEvent events, BBlockUIControlBlock block);
	}

	[Category, BaseType (typeof (UIImage))]
	public partial interface BBlock_UIImage
	{
		[Static, Export ("imageForSize:withDrawingBlock:")]
		UIImage ImageForSize (SizeF size, BBlockBlock drawingBlock);

		[Static, Export ("imageForSize:opaque:withDrawingBlock:")]
		UIImage ImageForSize (SizeF size, bool opaque, BBlockBlock drawingBlock);

		[Static, Export ("imageWithIdentifier:forSize:andDrawingBlock:")]
		UIImage ImageWithIdentifier (string identifier, SizeF size, BBlockBlock drawingBlock);

		[Static, Export ("imageWithIdentifier:opaque:forSize:andDrawingBlock:")]
		UIImage ImageWithIdentifier (string identifier, bool opaque, SizeF size, BBlockBlock drawingBlock);

		[Static, Export ("imageWithIdentifier:")]
		UIImage ImageWithIdentifier (string identifier);

		[Static, Export ("removeImageWithIdentifier:")]
		void RemoveImageWithIdentifier (string identifier);

		[Static, Export ("removeAllImages")]
		void RemoveAllImages ();
	}

	[Category, BaseType (typeof (SKStoreProductViewController))]
	public partial interface BBlock_SKStoreProductViewController
	{
		[Static, Export ("productViewControllerWithDidFinishBlock:")]
		IntPtr ProductViewControllerWithDidFinishBlock (SKStoreProductViewControllerBBlock block);

		[Export ("initWithProductViewControllerWithDidFinishBlock:")]
		IntPtr InitWithProductViewControllerWithDidFinishBlock (SKStoreProductViewControllerBBlock block);
	}

	[Category, BaseType (typeof (UIActionSheet))]
	public partial interface BBlock_UIActionSheet
	{
		[Export ("completionBlock")]
		void SetCompletionBlock (UIActionSheetBBlock block);

		[Export ("initWithTitle:cancelButtonTitle:destructiveButtonTitle:otherButtonTitle:completionBlock:")]
		IntPtr InitWithTitle (string title, string cancelTitle, string destructiveTitle, string otherTitle, UIActionSheetBBlock block);
	}

	[Category, BaseType (typeof (UIAlertView))]
	public partial interface BBlock_UIAlertView
	{
		[Export ("completionBlock")]
		void SetCompletionBlock (UIAlertViewBBlock block);

		[Export ("initWithTitle:message:cancelButtonTitle:otherButtonTitle:completionBlock:")]
		IntPtr InitWithTitle (string title, string message, string cancelTitle, string otherButtonTitle, UIAlertViewBBlock block);
	}

	[Category, BaseType (typeof (UIGestureRecognizer))]
	public partial interface BBlock_UIGestureRecognizer
	{
		[Export ("initWithBlock:")]
		IntPtr InitWithBlock (UIGestureRecognizerBBlock block);

		[Static, Export ("gestureRecognizerWithBlock:")]
		IntPtr GestureRecognizerWithBlock (UIGestureRecognizerBBlock block);
	}

	[Category, BaseType (typeof (UISwipeGestureRecognizer))]
	public partial interface BBlock_UISwipeGestureRecognizer
	{
		[Export ("initWithDirection:andBlock:")]
		IntPtr InitWithDirection (UISwipeGestureRecognizerDirection direction, UIGestureRecognizerBBlock block);

		[Static, Export ("gestureRecognizerWithDirection:andBlock:")]
		IntPtr GestureRecognizerWithDirection (UISwipeGestureRecognizerDirection direction, UIGestureRecognizerBBlock block);
	}

	[Category, BaseType (typeof (UITextField))]
	public partial interface BBlock_UITextField
	{
		[Export ("textFieldShouldReturnWithBlock:")]
		void TextFieldShouldReturnWithBlock (UITextFieldShouldReturnBBlock block);
	}
}

