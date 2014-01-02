using System;

namespace PubNubMessaging.Core
{
	public class Pubnub
	{
		#region "PubNub API Channel Methods"
		public void Subscribe<T>(string channel, Action<T> userCallback, Action<T> connectCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.Subscribe<T> (channel, userCallback, connectCallback, errorCallback);
		}

		public void Subscribe(string channel, Action<object> userCallback, Action<object> connectCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.Subscribe(channel, userCallback, connectCallback, errorCallback);
		}

		public bool Publish(string channel, object message, Action<object> userCallback, Action<PubnubClientError> errorCallback)
		{
			return pmm.Publish(channel, message, userCallback, errorCallback);
		}

		public bool Publish<T>(string channel, object message, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			return pmm.Publish<T>(channel, message, userCallback, errorCallback);
		}

		public void Presence<T>(string channel, Action<T> userCallback, Action<T> connectCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.Presence(channel, userCallback, connectCallback, errorCallback);
		}

		public void Presence(string channel, Action<object> userCallback, Action<object> connectCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.Presence<string>(channel, userCallback, connectCallback, errorCallback);
		}

		public bool DetailedHistory(string channel, long start, long end, int count, bool reverse, Action<object> userCallback, Action<PubnubClientError> errorCallback)
		{
			return pmm.DetailedHistory(channel, start, end, count, reverse, userCallback, errorCallback);
		}

		public bool DetailedHistory<T>(string channel, long start, long end, int count, bool reverse, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			return pmm.DetailedHistory<T>(channel, start, end, count, reverse, userCallback, errorCallback);
		}

		public bool DetailedHistory(string channel, long start, Action<object> userCallback, Action<PubnubClientError> errorCallback, bool reverse)
		{
			return DetailedHistory<object>(channel, start, -1, -1, reverse, userCallback, errorCallback);
		}

		public bool DetailedHistory<T>(string channel, long start, Action<T> userCallback, Action<PubnubClientError> errorCallback, bool reverse)
		{
			return DetailedHistory<T>(channel, start, -1, -1, reverse, userCallback, errorCallback);
		}

		public bool DetailedHistory(string channel, int count, Action<object> userCallback, Action<PubnubClientError> errorCallback)
		{
			return DetailedHistory<object>(channel, -1, -1, count, false, userCallback, errorCallback);
		}

		public bool DetailedHistory<T>(string channel, int count, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			return DetailedHistory<T>(channel, -1, -1, count, false, userCallback, errorCallback);
		}

		public bool HereNow(string channel, Action<object> userCallback, Action<PubnubClientError> errorCallback)
		{
			return pmm.HereNow(channel, userCallback, errorCallback);
		}

		public bool HereNow<T>(string channel, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			return pmm.HereNow<T>(channel, userCallback, errorCallback);
		}

		public void Unsubscribe<T>(string channel, Action<T> userCallback, Action<T> connectCallback, Action<T> disconnectCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.Unsubscribe<T>(channel, userCallback, connectCallback, disconnectCallback, errorCallback);
		}

		public void Unsubscribe(string channel, Action<object> userCallback, Action<object> connectCallback, Action<object> disconnectCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.Unsubscribe(channel, userCallback, connectCallback, disconnectCallback, errorCallback);
		}

		public void PresenceUnsubscribe(string channel, Action<object> userCallback, Action<object> connectCallback, Action<object> disconnectCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.PresenceUnsubscribe(channel, userCallback, connectCallback, disconnectCallback, errorCallback);
		}

		public void PresenceUnsubscribe<T>(string channel, Action<T> userCallback, Action<T> connectCallback, Action<T> disconnectCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.PresenceUnsubscribe<T>(channel, userCallback, connectCallback, disconnectCallback, errorCallback);
		}

		public bool Time(Action<object> userCallback, Action<PubnubClientError> errorCallback)
		{
			return pmm.Time(userCallback, errorCallback);
		}

		public bool Time<T>(Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			return pmm.Time<T> (userCallback, errorCallback);
		}

		public void AuditAccess<T>(string channel, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.AuditAccess(channel, userCallback, errorCallback);
		}

		public void AuditAccess<T>(Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.AuditAccess<T>(userCallback, errorCallback);
		}

		public bool GrantAccess<T>(string channel, bool read, bool write, int ttl, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			return GrantAccess<T>(channel, read, write, ttl, userCallback, errorCallback);
		}

		public bool GrantAccess<T>(string channel, bool read, bool write, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			return GrantAccess<T>(channel, read, write, userCallback, errorCallback);
		}

		public void AuditPresenceAccess<T>(string channel, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			pmm.AuditPresenceAccess<T> (channel, userCallback, errorCallback);
		}

		public bool GrantPresenceAccess<T>(string channel, bool read, bool write, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			return GrantPresenceAccess<T>(channel, read, write, userCallback, errorCallback);
		}

		public bool GrantPresenceAccess<T>(string channel, bool read, bool write, int ttl, Action<T> userCallback, Action<PubnubClientError> errorCallback)
		{
			return GrantPresenceAccess(channel, read, write, ttl, userCallback, errorCallback);
		}
		#endregion

		#region "PubNub API Other Methods"
		public void TerminateCurrentSubscriberRequest ()
		{
			pmm.TerminateCurrentSubscriberRequest ();
		}

		public void EnableSimulateNetworkFailForTestingOnly ()
		{
			pmm.EnableSimulateNetworkFailForTestingOnly ();
		}

		public void DisableSimulateNetworkFailForTestingOnly ()
		{
			pmm.DisableSimulateNetworkFailForTestingOnly ();
		}

		public void EnableMachineSleepModeForTestingOnly ()
		{
			pmm.EnableMachineSleepModeForTestingOnly ();
		}

		public void DisableMachineSleepModeForTestingOnly()
		{
			pmm.DisableMachineSleepModeForTestingOnly ();
		}

		public void EndPendingRequests ()
		{
			pmm.EndPendingRequests ();
		}

		public Guid GenerateGuid()
		{
			return pmm.GenerateGuid();
		}
		#endregion

		#region "Properties"
		public string AuthenticationKey {
			get {return pmm.AuthenticationKey;}
			set {pmm.AuthenticationKey = value;}
		}

		public PubnubProxy Proxy {
			get {return pmm.Proxy;}
			set {pmm.Proxy = value;}
		}

		public int HeartbeatInterval {
			get {return pmm.HeartbeatInterval;}
			set {pmm.HeartbeatInterval = value;}
		}

		public int NetworkCheckRetryInterval {
			get {return pmm.NetworkCheckRetryInterval;}
			set {pmm.NetworkCheckRetryInterval = value;}
		}

		public int NetworkCheckMaxRetries {
			get {return pmm.NetworkCheckMaxRetries;}
			set {pmm.NetworkCheckMaxRetries = value;}
		}

		public int NonSubscribeTimeout {
			get {return pmm.NonSubscribeTimeout;}
			set {pmm.NonSubscribeTimeout = value;}
		}

		public int SubscribeTimeout {
			get {return pmm.SubscribeTimeout;}
			set {pmm.SubscribeTimeout = value;}
		}

		public bool EnableResumeOnReconnect {
			get {return pmm.EnableResumeOnReconnect;}
			set {pmm.EnableResumeOnReconnect = value;}
		}

		public string SessionUUID {
			get {return pmm.SessionUUID;}
			set {pmm.SessionUUID = value;}
		}

		public string Origin {
			get {return pmm.Origin;}
			set {pmm.Origin = value;}
		}

		public IPubnubUnitTest PubnubUnitTest
		{
			get
			{
				return pmm.PubnubUnitTest;
			}
			set
			{
				pmm.PubnubUnitTest = value;
			}
		}

		#endregion

		#region "Constructors"
		PubnubMonoMac pmm;

		public Pubnub(string publishKey, string subscribeKey, string secretKey, string cipherKey, bool sslOn)
		{
			pmm = new PubnubMonoMac (publishKey, subscribeKey, secretKey, cipherKey, sslOn);
		}

		public Pubnub(string publishKey, string subscribeKey, string secretKey)
		{
			pmm = new PubnubMonoMac (publishKey, subscribeKey, secretKey);
		}

		public Pubnub(string publishKey, string subscribeKey)
		{
			pmm = new PubnubMonoMac (publishKey, subscribeKey);
		}
		#endregion
	}
}