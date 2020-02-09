using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Td = Telegram.Td;
using TdApi = Telegram.Td.Api;

namespace Telewear {
    public static class Comms {
        public static Page root;
        public static User user = new User();
        public static Td.Client client;
        public static void OnAuthorizationStateUpdated(TdApi.AuthorizationState authorizationState) {
            //DeviceInfo.Model + " " + .ToLower() + ", " + 
            if (authorizationState is TdApi.AuthorizationStateWaitTdlibParameters) {
                TdApi.TdlibParameters parameters = new TdApi.TdlibParameters();
                parameters.DatabaseDirectory = "tdlib";
                parameters.UseMessageDatabase = true;
                parameters.UseSecretChats = true;
                parameters.ApiId = 94575;
                parameters.ApiHash = "a3406de8d171bb422bb6ddf3bbd800e2";
                parameters.SystemLanguageCode = "en";
                parameters.DeviceModel = DeviceInfo.Idiom.ToString();
                parameters.SystemVersion = "Tizen " + DeviceInfo.VersionString;
                parameters.ApplicationVersion = "0.0.1";
                parameters.EnableStorageOptimizer = true;

                Comms.client.Send(new TdApi.SetTdlibParameters(parameters), new AuthorizationRequestHandler());
            } else if (authorizationState is TdApi.AuthorizationStateWaitEncryptionKey) {
                Comms.client.Send(new TdApi.CheckDatabaseEncryptionKey(), new AuthorizationRequestHandler());
            } else if (authorizationState is TdApi.AuthorizationStateWaitPhoneNumber) {
                App.Current.MainPage = new OnbEnterPhone(false);
            } else if (authorizationState is TdApi.AuthorizationStateWaitOtherDeviceConfirmation state) {
                //Console.WriteLine("Please confirm this login link on another device: " + state.Link);
            } else if (authorizationState is TdApi.AuthorizationStateWaitCode) {
                App.Current.MainPage = new OnbTypeAuthCode("3", false);

            } else if (authorizationState is TdApi.AuthorizationStateWaitRegistration) {
                App.Current.MainPage = new OnbNameSurname();

            } else {
                //("Unsupported authorization state:" + _newLine + _authorizationState);
            }
        }
        
    }
    public class AuthorizationRequestHandler : Td.ClientResultHandler {
        void Td.ClientResultHandler.OnResult(TdApi.BaseObject @object) {
            if (@object is TdApi.Error) {
                //Print("Receive an error:" + _newLine + @object);
                Comms.OnAuthorizationStateUpdated(null); // repeat last action
            } else {
                // result is already received through UpdateAuthorizationState, nothing to do
            }
        }
    }
    public class UpdatesHandler : Td.ClientResultHandler {
        void Td.ClientResultHandler.OnResult(TdApi.BaseObject @object) {
            if (@object is TdApi.UpdateAuthorizationState) {
                Comms.OnAuthorizationStateUpdated((@object as TdApi.UpdateAuthorizationState).AuthorizationState);
            } else {
                // Print("Unsupported update: " + @object);
            }
        }
    }
}
