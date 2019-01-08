// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: user.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Proto.User {
  public static partial class Users
  {
    static readonly string __ServiceName = "proto.user.Users";

    static readonly grpc::Marshaller<global::Proto.User.Request> __Marshaller_proto_user_Request = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Proto.User.Request.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Proto.User.Response> __Marshaller_proto_user_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Proto.User.Response.Parser.ParseFrom);

    static readonly grpc::Method<global::Proto.User.Request, global::Proto.User.Response> __Method_Get = new grpc::Method<global::Proto.User.Request, global::Proto.User.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_proto_user_Request,
        __Marshaller_proto_user_Response);

    static readonly grpc::Method<global::Proto.User.Request, global::Proto.User.Response> __Method_Post = new grpc::Method<global::Proto.User.Request, global::Proto.User.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Post",
        __Marshaller_proto_user_Request,
        __Marshaller_proto_user_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Proto.User.UserReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Users</summary>
    public abstract partial class UsersBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Proto.User.Response> Get(global::Proto.User.Request request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Proto.User.Response> Post(global::Proto.User.Request request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Users</summary>
    public partial class UsersClient : grpc::ClientBase<UsersClient>
    {
      /// <summary>Creates a new client for Users</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public UsersClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Users that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public UsersClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected UsersClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected UsersClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Proto.User.Response Get(global::Proto.User.Request request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Proto.User.Response Get(global::Proto.User.Request request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.User.Response> GetAsync(global::Proto.User.Request request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.User.Response> GetAsync(global::Proto.User.Request request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::Proto.User.Response Post(global::Proto.User.Request request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Post(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Proto.User.Response Post(global::Proto.User.Request request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Post, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.User.Response> PostAsync(global::Proto.User.Request request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.User.Response> PostAsync(global::Proto.User.Request request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Post, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override UsersClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UsersClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(UsersBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Post, serviceImpl.Post).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UsersBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Get, serviceImpl.Get);
      serviceBinder.AddMethod(__Method_Post, serviceImpl.Post);
    }

  }
}
#endregion
