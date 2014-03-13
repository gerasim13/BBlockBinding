using System.Drawing;
using System;

using MonoTouch.Foundation;

namespace BBlock {

	[BaseType (typeof (NSObject))]
	public partial interface BBlock {

		[Static, Export ("dispatchOnMainThread:")]
		void DispatchOnMainThread (Delegate block);

		[Static, Export ("dispatchAfter:onMainThread:")]
		void DispatchAfter (double delay, Delegate block);

		[Static, Export ("dispatchOnSynchronousQueue:")]
		void DispatchOnSynchronousQueue (Delegate block);

		[Static, Export ("dispatchOnSynchronousFileQueue:")]
		void DispatchOnSynchronousFileQueue (Delegate block);

		[Static, Export ("dispatchOnDefaultPriorityConcurrentQueue:")]
		void DispatchOnDefaultPriorityConcurrentQueue (Delegate block);

		[Static, Export ("dispatchOnLowPriorityConcurrentQueue:")]
		void DispatchOnLowPriorityConcurrentQueue (Delegate block);

		[Static, Export ("dispatchOnHighPriorityConcurrentQueue:")]
		void DispatchOnHighPriorityConcurrentQueue (Delegate block);
	}

	[Category, BaseType (typeof (NSArray))]
	public partial interface BBlock_NSArray {

		[Export ("enumerateEachObjectUsingBlock:")]
		void EnumerateEachObjectUsingBlock (Delegate block);

		[Export ("arrayWithObjectsMappedWithBlock:"), Verify ("NSArray may be reliably typed, check the documentation", "/Users/pavellitvinenko/Documents/Projects/Telesite/Thirdparty/iOS/BBlock/Categories/Foundation/NSArray+BBlock.h", Line = 17)]
		NSObject [] ArrayWithObjectsMappedWithBlock (Delegate block);
	}

	[Category, BaseType (typeof (NSDictionary))]
	public partial interface BBlock_NSDictionary {

		[Export ("enumerateEachKeyAndObjectUsingBlock:")]
		void EnumerateEachKeyAndObjectUsingBlock (Delegate block);

		[Export ("enumerateEachSortedKeyAndObjectUsingBlock:")]
		void EnumerateEachSortedKeyAndObjectUsingBlock (Delegate block);
	}

	[Category, BaseType (typeof (NSObject))]
	public partial interface BBlock_NSObject {

		[Export ("addObserverForKeyPath:options:block:")]
		string AddObserverForKeyPath (string keyPath, NSKeyValueObservingOptions options, NSObjectBBlock block);

		[Export ("removeObserverForToken:")]
		void RemoveObserverForToken (string identifier);

		[Export ("removeObserverBlocksForKeyPath:")]
		void RemoveObserverBlocksForKeyPath (string keyPath);

		[Export ("changeValueWithKey:changeBlock:")]
		void ChangeValueWithKey (string key, Delegate changeBlock);
	}

	[Category, BaseType (typeof (NSTimer))]
	public partial interface BBlock_NSTimer {

		[Static, Export ("timerWithTimeInterval:andBlock:")]
		BBlock_NSTimer TimerWithTimeInterval (double timeInterval, Delegate block);

		[Static, Export ("timerRepeats:withTimeInterval:andBlock:")]
		BBlock_NSTimer TimerRepeats (bool repeats, double timeInterval, Delegate block);

		[Static, Export ("scheduledTimerWithTimeInterval:andBlock:")]
		BBlock_NSTimer ScheduledTimerWithTimeInterval (double timeInterval, Delegate block);

		[Static, Export ("scheduledTimerRepeats:withTimeInterval:andBlock:")]
		BBlock_NSTimer ScheduledTimerRepeats (bool repeats, double timeInterval, Delegate block);
	}

	[Category, BaseType (typeof (NSArray))]
	public partial interface BBlock_NSArray {

		[Export ("enumerateEachObjectUsingBlock:")]
		void EnumerateEachObjectUsingBlock (Delegate block);

		[Export ("arrayWithObjectsMappedWithBlock:"), Verify ("NSArray may be reliably typed, check the documentation", "/Users/pavellitvinenko/Documents/Projects/Telesite/Thirdparty/iOS/BBlock/Categories/Foundation/NSArray+BBlock.h", Line = 17)]
		NSObject [] ArrayWithObjectsMappedWithBlock (Delegate block);
	}

	[Category, BaseType (typeof (NSDictionary))]
	public partial interface BBlock_NSDictionary {

		[Export ("enumerateEachKeyAndObjectUsingBlock:")]
		void EnumerateEachKeyAndObjectUsingBlock (Delegate block);

		[Export ("enumerateEachSortedKeyAndObjectUsingBlock:")]
		void EnumerateEachSortedKeyAndObjectUsingBlock (Delegate block);
	}

	[Category, BaseType (typeof (NSObject))]
	public partial interface BBlock_NSObject {

		[Export ("addObserverForKeyPath:options:block:")]
		string AddObserverForKeyPath (string keyPath, NSKeyValueObservingOptions options, NSObjectBBlock block);

		[Export ("removeObserverForToken:")]
		void RemoveObserverForToken (string identifier);

		[Export ("removeObserverBlocksForKeyPath:")]
		void RemoveObserverBlocksForKeyPath (string keyPath);

		[Export ("changeValueWithKey:changeBlock:")]
		void ChangeValueWithKey (string key, Delegate changeBlock);
	}

	[Category, BaseType (typeof (NSTimer))]
	public partial interface BBlock_NSTimer {

		[Static, Export ("timerWithTimeInterval:andBlock:")]
		BBlock_NSTimer TimerWithTimeInterval (double timeInterval, Delegate block);

		[Static, Export ("timerRepeats:withTimeInterval:andBlock:")]
		BBlock_NSTimer TimerRepeats (bool repeats, double timeInterval, Delegate block);

		[Static, Export ("scheduledTimerWithTimeInterval:andBlock:")]
		BBlock_NSTimer ScheduledTimerWithTimeInterval (double timeInterval, Delegate block);

		[Static, Export ("scheduledTimerRepeats:withTimeInterval:andBlock:")]
		BBlock_NSTimer ScheduledTimerRepeats (bool repeats, double timeInterval, Delegate block);
	}

	[Category, BaseType (typeof (SKProductsRequest))]
	public partial interface BBlock_SKProductsRequest {

		[Static, Export ("requestWithProductIdentifiers:andBlock:")]
		BBlock_SKProductsRequest RequestWithProductIdentifiers (NSSet productIdentifiers, SKProductsRequestBBlock block);

		[Export ("initWithProductIdentifiers:andBlock:")]
		IntPtr Constructor (NSSet productIdentifiers, SKProductsRequestBBlock block);
	}

	[Category, BaseType (typeof (SKStoreProductViewController))]
	public partial interface BBlock_SKStoreProductViewController {

		[Static, Export ("productViewControllerWithDidFinishBlock:")]
		NSObject ProductViewControllerWithDidFinishBlock (SKStoreProductViewControllerBBlock block);

		[Export ("initWithProductViewControllerWithDidFinishBlock:")]
		IntPtr Constructor (SKStoreProductViewControllerBBlock block);
	}

	[Category, BaseType (typeof (SKProductsRequest))]
	public partial interface BBlock_SKProductsRequest {

		[Static, Export ("requestWithProductIdentifiers:andBlock:")]
		BBlock_SKProductsRequest RequestWithProductIdentifiers (NSSet productIdentifiers, SKProductsRequestBBlock block);

		[Export ("initWithProductIdentifiers:andBlock:")]
		IntPtr Constructor (NSSet productIdentifiers, SKProductsRequestBBlock block);
	}

	[Category, BaseType (typeof (SKStoreProductViewController))]
	public partial interface BBlock_SKStoreProductViewController {

		[Static, Export ("productViewControllerWithDidFinishBlock:")]
		NSObject ProductViewControllerWithDidFinishBlock (SKStoreProductViewControllerBBlock block);

		[Export ("initWithProductViewControllerWithDidFinishBlock:")]
		IntPtr Constructor (SKStoreProductViewControllerBBlock block);
	}

	[Category, BaseType (typeof (UIActionSheet))]
	public partial interface BBlock_UIActionSheet {

		[Export ("completionBlock"), Verify ("ObjC method massaged into setter property", "/Users/pavellitvinenko/Documents/Projects/Telesite/Thirdparty/iOS/BBlock/Categories/UIKit/UIActionSheet+BBlock.h", Line = 15)]
		UIActionSheetBBlock CompletionBlock { set; }

		[Export ("initWithTitle:cancelButtonTitle:destructiveButtonTitle:otherButtonTitle:completionBlock:")]
		IntPtr Constructor (string title, string cancelTitle, string destructiveTitle, string otherTitle, UIActionSheetBBlock block);
	}

	[Category, BaseType (typeof (UIAlertView))]
	public partial interface BBlock_UIAlertView {

		[Export ("completionBlock"), Verify ("ObjC method massaged into setter property", "/Users/pavellitvinenko/Documents/Projects/Telesite/Thirdparty/iOS/BBlock/Categories/UIKit/UIAlertView+BBlock.h", Line = 15)]
		UIAlertViewBBlock CompletionBlock { set; }

		[Export ("initWithTitle:message:cancelButtonTitle:otherButtonTitle:completionBlock:")]
		IntPtr Constructor (string title, string message, string cancelTitle, string otherButtonTitle, UIAlertViewBBlock block);
	}

	[Category, BaseType (typeof (UIControl))]
	public partial interface BBlock_UIControl {

		[Export ("addActionForControlEvents:withBlock:")]
		void AddActionForControlEvents (UIControlEvents events, BBlockUIControlBlock block);
	}

	[Category, BaseType (typeof (UIGestureRecognizer))]
	public partial interface BBlock_UIGestureRecognizer {

		[Export ("initWithBlock:")]
		IntPtr Constructor (UIGestureRecognizerBBlock block);

		[Static, Export ("gestureRecognizerWithBlock:")]
		BBlock_UIGestureRecognizer GestureRecognizerWithBlock (UIGestureRecognizerBBlock block);
	}

	[Category, BaseType (typeof (UISwipeGestureRecognizer))]
	public partial interface BBlock_UISwipeGestureRecognizer {

		[Export ("initWithDirection:andBlock:")]
		IntPtr Constructor (UISwipeGestureRecognizerDirection direction, UIGestureRecognizerBBlock block);

		[Static, Export ("gestureRecognizerWithDirection:andBlock:")]
		BBlock_UISwipeGestureRecognizer GestureRecognizerWithDirection (UISwipeGestureRecognizerDirection direction, UIGestureRecognizerBBlock block);
	}

	[Category, BaseType (typeof (UIImage))]
	public partial interface BBlock_UIImage {

		[Static, Export ("imageForSize:withDrawingBlock:")]
		UIImage ImageForSize (SizeF size, Delegate drawingBlock);

		[Static, Export ("imageForSize:opaque:withDrawingBlock:")]
		UIImage ImageForSize (SizeF size, bool opaque, Delegate drawingBlock);

		[Static, Export ("imageWithIdentifier:forSize:andDrawingBlock:")]
		UIImage ImageWithIdentifier (string identifier, SizeF size, Delegate drawingBlock);

		[Static, Export ("imageWithIdentifier:opaque:forSize:andDrawingBlock:")]
		UIImage ImageWithIdentifier (string identifier, bool opaque, SizeF size, Delegate drawingBlock);

		[Static, Export ("imageWithIdentifier:")]
		UIImage ImageWithIdentifier (string identifier);

		[Static, Export ("removeImageWithIdentifier:")]
		void RemoveImageWithIdentifier (string identifier);

		[Static, Export ("removeAllImages")]
		void RemoveAllImages ();
	}

	[Category, BaseType (typeof (UIActionSheet))]
	public partial interface BBlock_UIActionSheet {

		[Export ("completionBlock"), Verify ("ObjC method massaged into setter property", "/Users/pavellitvinenko/Documents/Projects/Telesite/Thirdparty/iOS/BBlock/Categories/UIKit/UIActionSheet+BBlock.h", Line = 15)]
		UIActionSheetBBlock CompletionBlock { set; }

		[Export ("initWithTitle:cancelButtonTitle:destructiveButtonTitle:otherButtonTitle:completionBlock:")]
		IntPtr Constructor (string title, string cancelTitle, string destructiveTitle, string otherTitle, UIActionSheetBBlock block);
	}

	[Category, BaseType (typeof (UIAlertView))]
	public partial interface BBlock_UIAlertView {

		[Export ("completionBlock"), Verify ("ObjC method massaged into setter property", "/Users/pavellitvinenko/Documents/Projects/Telesite/Thirdparty/iOS/BBlock/Categories/UIKit/UIAlertView+BBlock.h", Line = 15)]
		UIAlertViewBBlock CompletionBlock { set; }

		[Export ("initWithTitle:message:cancelButtonTitle:otherButtonTitle:completionBlock:")]
		IntPtr Constructor (string title, string message, string cancelTitle, string otherButtonTitle, UIAlertViewBBlock block);
	}

	[Category, BaseType (typeof (UIControl))]
	public partial interface BBlock_UIControl {

		[Export ("addActionForControlEvents:withBlock:")]
		void AddActionForControlEvents (UIControlEvents events, BBlockUIControlBlock block);
	}

	[Category, BaseType (typeof (UIGestureRecognizer))]
	public partial interface BBlock_UIGestureRecognizer {

		[Export ("initWithBlock:")]
		IntPtr Constructor (UIGestureRecognizerBBlock block);

		[Static, Export ("gestureRecognizerWithBlock:")]
		BBlock_UIGestureRecognizer GestureRecognizerWithBlock (UIGestureRecognizerBBlock block);
	}

	[Category, BaseType (typeof (UISwipeGestureRecognizer))]
	public partial interface BBlock_UISwipeGestureRecognizer {

		[Export ("initWithDirection:andBlock:")]
		IntPtr Constructor (UISwipeGestureRecognizerDirection direction, UIGestureRecognizerBBlock block);

		[Static, Export ("gestureRecognizerWithDirection:andBlock:")]
		BBlock_UISwipeGestureRecognizer GestureRecognizerWithDirection (UISwipeGestureRecognizerDirection direction, UIGestureRecognizerBBlock block);
	}

	[Category, BaseType (typeof (UIImage))]
	public partial interface BBlock_UIImage {

		[Static, Export ("imageForSize:withDrawingBlock:")]
		UIImage ImageForSize (SizeF size, Delegate drawingBlock);

		[Static, Export ("imageForSize:opaque:withDrawingBlock:")]
		UIImage ImageForSize (SizeF size, bool opaque, Delegate drawingBlock);

		[Static, Export ("imageWithIdentifier:forSize:andDrawingBlock:")]
		UIImage ImageWithIdentifier (string identifier, SizeF size, Delegate drawingBlock);

		[Static, Export ("imageWithIdentifier:opaque:forSize:andDrawingBlock:")]
		UIImage ImageWithIdentifier (string identifier, bool opaque, SizeF size, Delegate drawingBlock);

		[Static, Export ("imageWithIdentifier:")]
		UIImage ImageWithIdentifier (string identifier);

		[Static, Export ("removeImageWithIdentifier:")]
		void RemoveImageWithIdentifier (string identifier);

		[Static, Export ("removeAllImages")]
		void RemoveAllImages ();
	}

	[Category, BaseType (typeof (UITextField))]
	public partial interface BBlock_UITextField {

		[Export ("textFieldShouldReturnWithBlock:")]
		void TextFieldShouldReturnWithBlock (UITextFieldShouldReturnBBlock block);
	}

	[Category, BaseType (typeof (UITextField))]
	public partial interface BBlock_UITextField {

		[Export ("textFieldShouldReturnWithBlock:")]
		void TextFieldShouldReturnWithBlock (UITextFieldShouldReturnBBlock block);
	}
}
