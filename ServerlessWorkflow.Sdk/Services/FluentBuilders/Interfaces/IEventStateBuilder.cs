﻿namespace ServerlessWorkflow.Sdk.Services.FluentBuilders;

/// <summary>
/// Defines the fundamentals of the service used to build <see cref="EventStateDefinition"/>s
/// </summary>
public interface IEventStateBuilder
    : IStateBuilder<EventStateDefinition>
{

    /// <summary>
    /// Builds, configures and adds a new <see cref="EventStateTriggerDefinition"/> to the <see cref="EventStateDefinition"/>
    /// </summary>
    /// <param name="triggerSetup">The <see cref="Action{T}"/> used to build the <see cref="EventStateTriggerDefinition"/></param>
    /// <returns>The configured <see cref="IEventStateBuilder"/></returns>
    IEventStateBuilder Trigger(Action<IEventStateTriggerBuilder> triggerSetup);

    /// <summary>
    /// Configures the <see cref="EventStateDefinition"/> to wait for all triggers to complete before resuming the workflow's execution
    /// </summary>
    /// <returns>The configured <see cref="IEventStateBuilder"/></returns>
    IEventStateBuilder WaitForAll();

    /// <summary>
    /// Configures the <see cref="EventStateDefinition"/> to wait for any trigger to complete before resuming the workflow's execution
    /// </summary>
    /// <returns>The configured <see cref="IEventStateBuilder"/></returns>
    IEventStateBuilder WaitForAny();

    /// <summary>
    /// Sets the duration after which the <see cref="EventStateDefinition"/> times out
    /// </summary>
    /// <param name="duration">The duration after which the <see cref="EventStateDefinition"/> times out</param>
    /// <returns>The configured <see cref="IEventStateBuilder"/></returns>
    IEventStateBuilder For(TimeSpan duration);

    /// <summary>
    /// Configures the <see cref="EventStateDefinition"/> to never time out
    /// </summary>
    /// <returns>The configured <see cref="IEventStateBuilder"/></returns>
    IEventStateBuilder Forever();

}
