using System;
using Foundation;
using ObjCRuntime;
using GoogleNearByMessageBinding;
namespace GoogleNearByMessageBinding
{
	// @interface GNSBeaconStrategyParams
	[BaseType(typeof(NSObject))]
	interface GNSBeaconStrategyParams
	{
		// @property (nonatomic) int includeIBeacons;
		[Export("includeIBeacons")]
		int IncludeIBeacons { get; set; }

		// @property (nonatomic) int allowInBackground;
		[Export("allowInBackground")]
		int AllowInBackground { get; set; }

		// @property (nonatomic) int lowPowerPreferred;
		[Export("lowPowerPreferred")]
		int LowPowerPreferred { get; set; }
	}

	// @interface GNSBeaconStrategy
	[BaseType(typeof(NSObject))]
	interface GNSBeaconStrategy : INSCopying
	{
		// @property (readonly, nonatomic) int includeIBeacons;
		[Export("includeIBeacons")]
		int IncludeIBeacons { get; }

		// @property (readonly, nonatomic) int allowInBackground;
		[Export("allowInBackground")]
		int AllowInBackground { get; }

		// @property (readonly, nonatomic) int lowPowerPreferred;
		[Export("lowPowerPreferred")]
		int LowPowerPreferred { get; }

		// +(instancetype)strategy;
		[Static]
		[Export("strategy")]
		GNSBeaconStrategy Strategy();

		// +(instancetype)strategyWithParamsBlock:(void (^)(GNSBeaconStrategyParams *))paramsBlock;
		[Static]
		[Export("strategyWithParamsBlock:")]
		GNSBeaconStrategy StrategyWithParamsBlock(Action<GNSBeaconStrategyParams> paramsBlock);
	}

	// typedef void (^GNSErrorStateHandler)(int);
	delegate void GNSErrorStateHandler(int arg0);

	[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const int kGNSMessageMaximumContentSize;
		[Field("kGNSMessageMaximumContentSize", "__Internal")]
		int kGNSMessageMaximumContentSize { get; }

		// extern const int kGNSMessageMaximumTypeLength;
		[Field("kGNSMessageMaximumTypeLength", "__Internal")]
		int kGNSMessageMaximumTypeLength { get; }
	}

	// @interface GNSMessage
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface GNSMessage
	{
		// @property (readonly, copy, nonatomic) int * messageNamespace;
		[Export("messageNamespace", ArgumentSemantic.Copy)]
		IntPtr MessageNamespace { get; }

		// @property (readonly, copy, nonatomic) int * type;
		[Export("type", ArgumentSemantic.Copy)]
		IntPtr Type { get; }

		// @property (readonly, copy, nonatomic) int * content;
		[Export("content", ArgumentSemantic.Copy)]
		IntPtr Content { get; }

		// +(instancetype)messageWithContent:(id)content;
		[Static]
		[Export("messageWithContent:")]
		GNSMessage MessageWithContent(NSObject content);

		// +(instancetype)messageWithContent:(id)content type:(id)type;
		[Static]
		[Export("messageWithContent:type:")]
		GNSMessage MessageWithContent(NSObject content, NSObject type);
	}

	// typedef void (^GNSMessageHandler)(GNSMessage *);
	delegate void GNSMessageHandler(GNSMessage arg0);

	// typedef void (^GNSMessageManagerParamsBlock)(GNSMessageManagerParams *);
	delegate void GNSMessageManagerParamsBlock(GNSMessageManagerParams arg0);

	// typedef void (^GNSPublicationParamsBlock)(GNSPublicationParams *);
	delegate void GNSPublicationParamsBlock(GNSPublicationParams arg0);

	// typedef void (^GNSSubscriptionParamsBlock)(GNSSubscriptionParams *);
	delegate void GNSSubscriptionParamsBlock(GNSSubscriptionParams arg0);

	// @protocol GNSPublication
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface GNSPublication
	{
	}

	// @protocol GNSSubscription
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface GNSSubscription
	{
	}

	// @interface GNSMessageManagerParams
	[BaseType(typeof(NSObject))]
	interface GNSMessageManagerParams
	{
		// @property (getter = shouldShowBluetoothPowerAlert, nonatomic) int showBluetoothPowerAlert;
		[Export("showBluetoothPowerAlert")]
		int ShowBluetoothPowerAlert { [Bind("shouldShowBluetoothPowerAlert")] get; set; }

		// @property (copy, nonatomic) GNSErrorStateHandler microphonePermissionErrorHandler;
		[Export("microphonePermissionErrorHandler", ArgumentSemantic.Copy)]
		GNSErrorStateHandler MicrophonePermissionErrorHandler { get; set; }

		// @property (copy, nonatomic) GNSErrorStateHandler bluetoothPermissionErrorHandler;
		[Export("bluetoothPermissionErrorHandler", ArgumentSemantic.Copy)]
		GNSErrorStateHandler BluetoothPermissionErrorHandler { get; set; }

		// @property (copy, nonatomic) GNSErrorStateHandler bluetoothPowerErrorHandler;
		[Export("bluetoothPowerErrorHandler", ArgumentSemantic.Copy)]
		GNSErrorStateHandler BluetoothPowerErrorHandler { get; set; }

		// @property (getter = shouldUseBestAudioSessionCategory, nonatomic) int useBestAudioSessionCategory;
		[Export("useBestAudioSessionCategory")]
		int UseBestAudioSessionCategory { [Bind("shouldUseBestAudioSessionCategory")] get; set; }
	}

	// @interface GNSMessageManager
	[BaseType(typeof(NSObject))]
	interface GNSMessageManager
	{
		// -(instancetype)initWithAPIKey:(id)apiKey;
		[Export("initWithAPIKey:")]
		IntPtr Constructor(NSString apiKey);

		// -(instancetype)initWithAPIKey:(id)apiKey paramsBlock:(GNSMessageManagerParamsBlock)paramsBlock;
		[Export("initWithAPIKey:paramsBlock:")]
		IntPtr Constructor(NSString apiKey, GNSMessageManagerParamsBlock paramsBlock);

		// -(id<GNSPublication>)publicationWithMessage:(GNSMessage *)message;
		[Export("publicationWithMessage:")]
		GNSPublication PublicationWithMessage(GNSMessage message);

		// -(id<GNSPublication>)publicationWithMessage:(GNSMessage *)message paramsBlock:(GNSPublicationParamsBlock)paramsBlock;
		[Export("publicationWithMessage:paramsBlock:")]
		GNSPublication PublicationWithMessage(GNSMessage message, GNSPublicationParamsBlock paramsBlock);

		// -(id<GNSSubscription>)subscriptionWithMessageFoundHandler:(GNSMessageHandler)messageFoundHandler messageLostHandler:(GNSMessageHandler)messageLostHandler;
		[Export("subscriptionWithMessageFoundHandler:messageLostHandler:")]
		GNSSubscription SubscriptionWithMessageFoundHandler(GNSMessageHandler messageFoundHandler, GNSMessageHandler messageLostHandler);

		// -(id<GNSSubscription>)subscriptionWithMessageFoundHandler:(GNSMessageHandler)messageFoundHandler messageLostHandler:(GNSMessageHandler)messageLostHandler paramsBlock:(GNSSubscriptionParamsBlock)paramsBlock;
		[Export("subscriptionWithMessageFoundHandler:messageLostHandler:paramsBlock:")]
		GNSSubscription SubscriptionWithMessageFoundHandler(GNSMessageHandler messageFoundHandler, GNSMessageHandler messageLostHandler, GNSSubscriptionParamsBlock paramsBlock);

		// +(void)setDebugLoggingEnabled:(id)enabled;
		[Static]
		[Export("setDebugLoggingEnabled:")]
		void SetDebugLoggingEnabled(NSObject enabled);

		// +(id)isDebugLoggingEnabled;
		[Static]
		[Export("isDebugLoggingEnabled")]
		//[Verify(MethodToProperty)]
		NSObject IsDebugLoggingEnabled { get; }
	}

	// typedef void (^GNSOperationStatusHandler)(GNSOperationStatus);
	delegate void GNSOperationStatusHandler(GNSOperationStatus arg0);

	// typedef void (^GNSPermissionHandler)(BOOL);
	delegate void GNSPermissionHandler(bool arg0);

	// typedef void (^GNSPermissionRequestHandler)(GNSPermissionHandler);
	delegate void GNSPermissionRequestHandler(GNSPermissionHandler arg0);

	// @interface GNSPermission : NSObject
	[BaseType(typeof(NSObject))]
	interface GNSPermission
	{
		// -(instancetype)initWithChangedHandler:(GNSPermissionHandler)changedHandler;
		[Export("initWithChangedHandler:")]
		IntPtr Constructor(GNSPermissionHandler changedHandler);

		// +(BOOL)isGranted;
		[Static]
		[Export("isGranted")]
		//[Verify(MethodToProperty)]
		bool IsGranted { get; }

		// +(void)setGranted:(BOOL)granted;
		[Static]
		[Export("setGranted:")]
		void SetGranted(bool granted);
	}

	// @interface GNSPublicationParams : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GNSPublicationParams : INSCopying
	{
		// @property (copy, nonatomic) GNSStrategy * strategy;
		[Export("strategy", ArgumentSemantic.Copy)]
		GNSStrategy Strategy { get; set; }

		// @property (copy, nonatomic) GNSOperationStatusHandler statusHandler;
		[Export("statusHandler", ArgumentSemantic.Copy)]
		GNSOperationStatusHandler StatusHandler { get; set; }

		// @property (copy, nonatomic) GNSPermissionRequestHandler permissionRequestHandler;
		[Export("permissionRequestHandler", ArgumentSemantic.Copy)]
		GNSPermissionRequestHandler PermissionRequestHandler { get; set; }
	}

	// @interface GNSStrategyParams : NSObject
	[BaseType(typeof(NSObject))]
	interface GNSStrategyParams
	{
		// @property (nonatomic) GNSDiscoveryMode discoveryMode;
		[Export("discoveryMode", ArgumentSemantic.Assign)]
		GNSDiscoveryMode DiscoveryMode { get; set; }

		// @property (nonatomic) GNSDiscoveryMediums discoveryMediums;
		[Export("discoveryMediums", ArgumentSemantic.Assign)]
		GNSDiscoveryMediums DiscoveryMediums { get; set; }

		// @property (nonatomic) BOOL allowInBackground;
		[Export("allowInBackground")]
		bool AllowInBackground { get; set; }
	}

	// @interface GNSStrategy : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GNSStrategy : INSCopying
	{
		// @property (readonly, nonatomic) GNSDiscoveryMode discoveryMode;
		[Export("discoveryMode")]
		GNSDiscoveryMode DiscoveryMode { get; }

		// @property (readonly, nonatomic) GNSDiscoveryMediums discoveryMediums;
		[Export("discoveryMediums")]
		GNSDiscoveryMediums DiscoveryMediums { get; }

		// @property (readonly, nonatomic) BOOL allowInBackground;
		[Export("allowInBackground")]
		bool AllowInBackground { get; }

		// +(instancetype)strategy;
		[Static]
		[Export("strategy")]
		GNSStrategy Strategy();

		// +(instancetype)strategyWithParamsBlock:(void (^)(GNSStrategyParams *))paramsBlock;
		[Static]
		[Export("strategyWithParamsBlock:")]
		GNSStrategy StrategyWithParamsBlock(Action<GNSStrategyParams> paramsBlock);
	}

	// @interface GNSSubscriptionParams : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GNSSubscriptionParams : INSCopying
	{
		// @property (nonatomic) GNSDeviceTypes deviceTypesToDiscover;
		[Export("deviceTypesToDiscover", ArgumentSemantic.Assign)]
		GNSDeviceTypes DeviceTypesToDiscover { get; set; }

		// @property (copy, nonatomic) NSString * messageNamespace;
		[Export("messageNamespace")]
		string MessageNamespace { get; set; }

		// @property (copy, nonatomic) NSString * type;
		[Export("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) GNSStrategy * strategy;
		[Export("strategy", ArgumentSemantic.Copy)]
		GNSStrategy Strategy { get; set; }

		// @property (copy, nonatomic) GNSBeaconStrategy * beaconStrategy;
		[Export("beaconStrategy", ArgumentSemantic.Copy)]
		GNSBeaconStrategy BeaconStrategy { get; set; }

		// @property (copy, nonatomic) GNSOperationStatusHandler statusHandler;
		[Export("statusHandler", ArgumentSemantic.Copy)]
		GNSOperationStatusHandler StatusHandler { get; set; }

		// @property (copy, nonatomic) GNSPermissionRequestHandler permissionRequestHandler;
		[Export("permissionRequestHandler", ArgumentSemantic.Copy)]
		GNSPermissionRequestHandler PermissionRequestHandler { get; set; }
	}
}
