// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/weather.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Proto.Weather {
  public static partial class Weathers
  {
    static readonly string __ServiceName = "proto.weather.Weathers";

    static readonly grpc::Marshaller<global::Proto.Weather.Request> __Marshaller_proto_weather_Request = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Proto.Weather.Request.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Proto.Weather.Response> __Marshaller_proto_weather_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Proto.Weather.Response.Parser.ParseFrom);

    static readonly grpc::Method<global::Proto.Weather.Request, global::Proto.Weather.Response> __Method_Get = new grpc::Method<global::Proto.Weather.Request, global::Proto.Weather.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_proto_weather_Request,
        __Marshaller_proto_weather_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Proto.Weather.WeatherReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Weathers</summary>
    public abstract partial class WeathersBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Proto.Weather.Response> Get(global::Proto.Weather.Request request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Weathers</summary>
    public partial class WeathersClient : grpc::ClientBase<WeathersClient>
    {
      /// <summary>Creates a new client for Weathers</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public WeathersClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Weathers that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public WeathersClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected WeathersClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected WeathersClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Proto.Weather.Response Get(global::Proto.Weather.Request request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Proto.Weather.Response Get(global::Proto.Weather.Request request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.Weather.Response> GetAsync(global::Proto.Weather.Request request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.Weather.Response> GetAsync(global::Proto.Weather.Request request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override WeathersClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WeathersClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(WeathersBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WeathersBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Get, serviceImpl.Get);
    }

  }
}
#endregion
