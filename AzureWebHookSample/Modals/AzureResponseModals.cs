using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureWebHookSample.Modals
{
    public class AzureResponseModals
    {
        public String SubscriptionId { get; set; }

        public int NotificationId { get; set; }

        public String EventType { get; set; }

        public Resource Resource { get; set; }
    }
    public class Account
    {
        public string id { get; set; }
    }

    public class Avatar
    {
        public string href { get; set; }
    }

    public class Collection
    {
        public string id { get; set; }
    }

    public class DetailedMessage
    {
        public string text { get; set; }
        public string html { get; set; }
        public string markdown { get; set; }
    }

    public class Fields
    {
        [JsonProperty("System.Rev")]
        public SystemRev SystemRev { get; set; }

        [JsonProperty("System.AuthorizedDate")]
        public SystemAuthorizedDate SystemAuthorizedDate { get; set; }

        [JsonProperty("System.RevisedDate")]
        public SystemRevisedDate SystemRevisedDate { get; set; }

        [JsonProperty("System.State")]
        public SystemState SystemState { get; set; }

        [JsonProperty("System.Reason")]
        public SystemReason SystemReason { get; set; }

        [JsonProperty("System.AssignedTo")]
        public SystemAssignedTo SystemAssignedTo { get; set; }

        [JsonProperty("System.ChangedDate")]
        public SystemChangedDate SystemChangedDate { get; set; }

        [JsonProperty("System.Watermark")]
        public SystemWatermark SystemWatermark { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.Severity")]
        public MicrosoftVSTSCommonSeverity MicrosoftVSTSCommonSeverity { get; set; }

        [JsonProperty("System.AreaPath")]
        public string SystemAreaPath { get; set; }

        [JsonProperty("System.TeamProject")]
        public string SystemTeamProject { get; set; }

        [JsonProperty("System.IterationPath")]
        public string SystemIterationPath { get; set; }

        [JsonProperty("System.WorkItemType")]
        public string SystemWorkItemType { get; set; }

        [JsonProperty("System.CreatedDate")]
        public DateTime SystemCreatedDate { get; set; }

        [JsonProperty("System.CreatedBy")]
        public SystemCreatedBy SystemCreatedBy { get; set; }

        [JsonProperty("System.ChangedBy")]
        public SystemChangedBy SystemChangedBy { get; set; }

        [JsonProperty("System.Title")]
        public string SystemTitle { get; set; }

        [JsonProperty("WEF_EB329F44FE5F4A94ACB1DA153FDF38BA_Kanban.Column")]
        public string WEFEB329F44FE5F4A94ACB1DA153FDF38BAKanbanColumn { get; set; }
    }

    public class Links
    {
        public Avatar avatar { get; set; }
        public Self self { get; set; }
        public Parent parent { get; set; }
        public WorkItemUpdates workItemUpdates { get; set; }
    }

    public class Message
    {
        public string text { get; set; }
        public string html { get; set; }
        public string markdown { get; set; }
    }

    public class MicrosoftVSTSCommonSeverity
    {
        public string oldValue { get; set; }
        public string newValue { get; set; }
    }

    public class Parent
    {
        public string href { get; set; }
    }

    public class Project
    {
        public string id { get; set; }
    }

    public class Resource
    {
        public int id { get; set; }
        public int workItemId { get; set; }
        public int rev { get; set; }
        public RevisedBy revisedBy { get; set; }
        public DateTime revisedDate { get; set; }
        public Fields fields { get; set; }
        public Links _links { get; set; }
        public string url { get; set; }
        public Revision revision { get; set; }
    }

    public class ResourceContainers
    {
        public Collection collection { get; set; }
        public Account account { get; set; }
        public Project project { get; set; }
    }

    public class RevisedBy
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string url { get; set; }
        public Links _links { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class Revision
    {
        public int id { get; set; }
        public int rev { get; set; }
        public Fields fields { get; set; }
        public string url { get; set; }
    }

    public class Root
    {
        public string subscriptionId { get; set; }
        public int notificationId { get; set; }
        public string id { get; set; }
        public string eventType { get; set; }
        public string publisherId { get; set; }
        public Message message { get; set; }
        public DetailedMessage detailedMessage { get; set; }
        public Resource resource { get; set; }
        public string resourceVersion { get; set; }
        public ResourceContainers resourceContainers { get; set; }
        public DateTime createdDate { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class SystemAssignedTo
    {
        public string oldValue { get; set; }
        public string newValue { get; set; }
    }

    public class SystemAuthorizedDate
    {
        public DateTime oldValue { get; set; }
        public DateTime newValue { get; set; }
    }

    public class SystemChangedBy
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class SystemChangedDate
    {
        public DateTime oldValue { get; set; }
        public DateTime newValue { get; set; }
    }

    public class SystemCreatedBy
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class SystemReason
    {
        public string oldValue { get; set; }
        public string newValue { get; set; }
    }

    public class SystemRev
    {
        public string oldValue { get; set; }
        public string newValue { get; set; }
    }

    public class SystemRevisedDate
    {
        public DateTime oldValue { get; set; }
        public DateTime newValue { get; set; }
    }

    public class SystemState
    {
        public string oldValue { get; set; }
        public string newValue { get; set; }
    }

    public class SystemWatermark
    {
        public string oldValue { get; set; }
        public string newValue { get; set; }
    }

    public class WorkItemUpdates
    {
        public string href { get; set; }
    }
}
