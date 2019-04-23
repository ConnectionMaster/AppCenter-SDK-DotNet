// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Foundation;
using Microsoft.AppCenter.iOS.Bindings;

namespace Microsoft.AppCenter.Data.iOS.Bindings
{
    // @interface MSDataStore : MSService
    [BaseType(typeof(NSObject))]
    interface MSDataStore
    {
        // + (void)setTokenExchangeUrl:(NSString *)tokenExchangeUrl;
        [Static]
        [Export("setTokenExchangeUrl:")]
        void SetTokenExchangeUrl(string tokenExchangeUrl);

        // + (BOOL)isEnabled;
        [Static]
        [Export("isEnabled")]
        bool IsEnabled();

        // + (void)setEnabled:(BOOL)isEnabled;
        [Static]
        [Export("setEnabled:")]
        void SetEnabled(bool isEnabled);

        // + (void)readWithPartition:(NSString *)partition documentId:(NSString*) documentId documentType:(Class) documentType completionHandler:(MSDocumentWrapperCompletionHandler) completionHandler;
        [Static]
        [Export("readWithPartition:documentId:documentType:completionHandler:")]
        void ReadWithPartition(string partition, string documentId, Type documentType, MSDocumentWrapperCompletionHandler completionHandler);

        // + (void)readWithPartition:(NSString *)partition documentId:(NSString*) documentId documentType:(Class) documentType readOptions:(MSReadOptions *_Nullable)readOptions completionHandler:(MSDocumentWrapperCompletionHandler) completionHandler;
        [Static]
        [Export("readWithPartition:documentId:documentType:readOptions:completionHandler:")]
        void ReadWithPartition(string partition, string documentId, Type documentType, [NullAllowed] MSReadOptions readOptions, MSDocumentWrapperCompletionHandler completionHandler);

        // + (void)listWithPartition:(NSString *)partition documentType:(Class) documentType completionHandler:(MSPaginatedDocumentsCompletionHandler) completionHandler;
        [Static]
        [Export("listWithPartition:documentType:completionHandler:")]
        void ListWithPartition(string partition, Type documentType, MSPaginatedDocumentsCompletionHandler completionHandler);

        // + (void) createWithPartition:(NSString*) partition documentId:(NSString*) documentId document:(id<MSSerializableDocument>) document completionHandler:(MSDocumentWrapperCompletionHandler) completionHandler;
        [Static]
        [Export("createWithPartition:documentId:document:completionHandler:")]
        void CreateWithPartition(string partition, string documentId, string document, MSDocumentWrapperCompletionHandler completionHandler);

        // + (void) createWithPartition:(NSString*) partition documentId:(NSString*) documentId document:(id<MSSerializableDocument>) document writeOptions:(MSWriteOptions* _Nullable) writeOptions completionHandler:(MSDocumentWrapperCompletionHandler) completionHandler;
        [Static]
        [Export("createWithPartition:documentId:document:writeOptions:completionHandler:")]
        void CreateWithPartition(string partition, string documentId, string document, [NullAllowed] MSWriteOptions writeOptions, MSDocumentWrapperCompletionHandler completionHandler);

        // + (void) replaceWithPartition:(NSString*) partition documentId:(NSString*) documentId document:(id<MSSerializableDocument>) document completionHandler:(MSDocumentWrapperCompletionHandler) completionHandler;
        [Static]
        [Export("replaceWithPartition:documentId:document:completionHandler:")]
        void ReplaceWithPartition(string partition, string documentId, string document, MSDocumentWrapperCompletionHandler completionHandler);

        // + (void) replaceWithPartition:(NSString*) partition documentId:(NSString*) documentId document:(id<MSSerializableDocument>) document writeOptions:(MSWriteOptions* _Nullable) writeOptions completionHandler:(MSDocumentWrapperCompletionHandler) completionHandler;
        [Static]
        [Export("replaceWithPartition:documentId:document:writeOptions:completionHandler:")]
        void ReplaceWithPartition(string partition, string documentId, string document, [NullAllowed] MSWriteOptions writeOptions, MSDocumentWrapperCompletionHandler completionHandler);

        // + (void)deleteWithPartition:(NSString *)partition documentId:(NSString*) documentId completionHandler:(MSDocumentWrapperCompletionHandler) completionHandler;
        [Static]
        [Export("deleteWithPartition:documentId:completionHandler:")]
        void DeleteWithPartition(string partition, string documentId, MSDocumentWrapperCompletionHandler completionHandler);

        // + (void) deleteWithPartition:(NSString*) partition documentId:(NSString*) documentId writeOptions:(MSWriteOptions* _Nullable) writeOptions completionHandler:(MSDocumentWrapperCompletionHandler) completionHandler;
        [Static]
        [Export("deleteWithPartition:documentId:writeOptions:completionHandler:")]
        void DeleteWithPartition(string partition, string documentId, [NullAllowed] MSWriteOptions writeOptions, MSDocumentWrapperCompletionHandler completionHandler);
    }

    // @interface MSDataSourceError : NSObject
    [BaseType(typeof(NSObject))]
    interface MSDataSourceError
    {
        // @property(nonatomic, strong, readonly) NSError *error;
        [Export("error")]
        NSError Error();

        // @property(nonatomic, readonly) NSInteger errorCode;
        [Export("errorCode")]
        IntPtr ErrorCode();
    }

    // @interface MSPage : NSObject
    [BaseType(typeof(NSObject))]
    interface MSPage
    {
        // @property(nonatomic, strong, readonly) NSError *error;
        [Export("error")]
        NSError Error();

        // @property(readonly) NSArray<MSDocumentWrapper *> *items;
        [Export("items")]
        MSDocumentWrapper[] Items();
    }

    // @interface MSReadOptions : MSBaseOptions
    [BaseType(typeof(MSBaseOptions))]
    interface MSReadOptions
    {

    }

    // @interface MSWriteOptions : MSBaseOptions
    [BaseType(typeof(MSBaseOptions))]
    interface MSWriteOptions
    {

    }

    // @interface MSBaseOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface MSBaseOptions
    {
        // @property long deviceTimeToLive;
        [Export("deviceTimeToLive")]
        long DeviceTimeToLive { get; set; }
    }

    // @interface MSDocumentWrapper : NSObject
    [BaseType(typeof(NSObject))]
    interface MSDocumentWrapper
    {
        // @property(nonatomic, strong, readonly) NSString* jsonValue;
        [Export("jsonValue")]
        string JsonValue { get; set; }

        // @property(nonatomic, strong, readonly) id<MSSerializableDocument> deserializedValue;
        [Export("deserializedValue")]
        string DeserializedValue { get; set; }

        // @property(nonatomic, strong, readonly) NSString* partition;
        [Export("partition")]
        string Partition { get; set; }

        // @property(nonatomic, strong, readonly) NSString* documentId;
        [Export("documentId")]
        string DocumentId { get; set; }

        // @property(nonatomic, strong, readonly) NSString* eTag;
        [Export("eTag")]
        string ETag { get; set; }

        // @property(nonatomic, strong, readonly) NSDate* lastUpdatedDate;
        [Export("lastUpdatedDate")]
        NSDate LastUpdatedDate { get; set; }

        // @property(nonatomic, strong, readonly) MSDataSourceError* error;
        [Export("error")]
        MSDataSourceError Error { get; set; }

        // @property(nonatomic, readonly) BOOL fromDeviceCache;
        [Export("fromDeviceCache")]
        bool FromDeviceCache { get; set; }
    }

    // @interface MSPaginatedDocuments : NSObject
    [BaseType(typeof(NSObject))]
    interface MSPaginatedDocuments
    {
        // - (MSPage*) currentPage;
        [Export("currentPage")]
        MSPage CurrentPage();

        // - (BOOL) hasNextPage;
        [Export("hasNextPage")]
        bool HasNextPage();

        // - (void) nextPageWithCompletionHandler:(void (^)(MSPage* page))completionHandler;
        [Export("nextPageWithCompletionHandler:")]
        void NextPageWithCompletionHandler(NextPageCompletionHandler handler);
    }

    delegate void NextPageCompletionHandler(MSPage page);

    // typedef void (^MSDocumentWrapperCompletionHandler)(MSDocumentWrapper *document);
    delegate void MSDocumentWrapperCompletionHandler(MSDocumentWrapper document);

    // typedef void (^MSPaginatedDocumentsCompletionHandler)(MSPaginatedDocuments* documents);
    delegate void MSPaginatedDocumentsCompletionHandler(MSPaginatedDocuments document);
}
