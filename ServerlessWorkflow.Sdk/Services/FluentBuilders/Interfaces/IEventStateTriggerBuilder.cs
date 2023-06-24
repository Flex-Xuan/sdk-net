﻿namespace ServerlessWorkflow.Sdk.Services.FluentBuilders;

/// <summary>
/// Defines the fundamentals of the service used to build <see cref="EventStateTriggerDefinition"/>s
/// </summary>
public interface IEventStateTriggerBuilder
    : IActionCollectionBuilder<IEventStateTriggerBuilder>
{

    /// <summary>
    /// Configures the <see cref="EventStateTriggerDefinition"/> to consume the <see cref="CloudEvent"/>s defined by the specified <see cref="EventDefinition"/>s
    /// </summary>
    /// <param name="events">An array containing the reference names of the <see cref="EventDefinition"/>s that define the <see cref="CloudEvent"/>s to consume</param>
    /// <returns>The configured <see cref="IEventStateTriggerBuilder"/></returns>
    IEventStateTriggerBuilder On(params string[] events);

    /// <summary>
    /// Configures the <see cref="EventStateTriggerDefinition"/> to consume the <see cref="CloudEvent"/>s defined by the specified <see cref="EventDefinition"/>s
    /// </summary>
    /// <param name="eventSetups">An array containing the <see cref="Action"/>s used to build the <see cref="EventDefinition"/>s that define the <see cref="CloudEvent"/>s to consume</param>
    /// <returns>The configured <see cref="IEventStateTriggerBuilder"/></returns>
    IEventStateTriggerBuilder On(params Action<IEventBuilder>[] eventSetups);

    /// <summary>
    /// Configures the <see cref="EventStateTriggerDefinition"/> to consume the <see cref="CloudEvent"/>s defined by the specified <see cref="EventDefinition"/>s
    /// </summary>
    /// <param name="events">An array the <see cref="EventDefinition"/>s that define the <see cref="CloudEvent"/>s to consume</param>
    /// <returns>The configured <see cref="IEventStateTriggerBuilder"/></returns>
    IEventStateTriggerBuilder On(params EventDefinition[] events);

    /// <summary>
    /// Configures the <see cref="EventStateTriggerDefinition"/> to filter the payload of consumed <see cref="CloudEvent"/>s
    /// </summary>
    /// <param name="expression">The workflow expression used to filter payload of consumed <see cref="CloudEvent"/>s</param>
    /// <returns>The configured <see cref="IEventStateTriggerBuilder"/></returns>
    IEventStateTriggerBuilder FilterPayload(string expression);

    /// <summary>
    /// Configures the <see cref="EventStateTriggerDefinition"/> to select the state data element to which the action results should be added/merged into
    /// </summary>
    /// <param name="expression">The expression that selects a state data element to which the action results should be added/merged into</param>
    /// <returns>The configured <see cref="IEventStateTriggerBuilder"/></returns>
    IEventStateTriggerBuilder ToStateData(string expression);

    /// <summary>
    /// Builds the <see cref="EventStateTriggerDefinition"/>
    /// </summary>
    /// <returns>A new <see cref="EventStateTriggerDefinition"/></returns>
    EventStateTriggerDefinition Build();

}
