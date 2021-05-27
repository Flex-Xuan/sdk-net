﻿using FluentValidation;
using ServerlessWorkflow.Sdk.Models;

namespace ServerlessWorkflow.Sdk.Services.Validation
{
    /// <summary>
    /// Represents a service used to validate <see cref="EventCaseDefinition"/>s
    /// </summary>
    public class EventCaseDefinitionValidator
        : SwitchCaseDefinitionValidator<EventCaseDefinition>
    {

        /// <summary>
        /// Initializes a new <see cref="EventCaseDefinitionValidator"/>
        /// </summary>
        /// <param name="workflow">The <see cref="WorkflowDefinition"/> the <see cref="EventCaseDefinition"/> to validate belongs to</param>
        /// <param name="state">The <see cref="SwitchStateDefinition"/> the <see cref="EventCaseDefinition"/> to validate belongs to</param>
        public EventCaseDefinitionValidator(WorkflowDefinition workflow, SwitchStateDefinition state)
            : base(workflow, state)
        {
            this.RuleFor(c => c.Event)
                .NotEmpty()
                .WithErrorCode($"{nameof(EventCaseDefinition)}.{nameof(EventCaseDefinition.Event)}");
            this.RuleFor(c => c.Event)
                .Must(ReferenceExistingEvent)
                .When(c => !string.IsNullOrWhiteSpace(c.Event))
                .WithErrorCode($"{nameof(EventCaseDefinition)}.{nameof(EventCaseDefinition.Event)}");
        }

        /// <summary>
        /// Determines whether or not the specified <see cref="EventDefinition"/> exists
        /// </summary>
        /// <param name="eventName">The name of the <see cref="EventDefinition"/> to check</param>
        /// <returns>A boolean indicating whether or not the specified <see cref="EventDefinition"/> exists</returns>
        protected virtual bool ReferenceExistingEvent(string eventName)
        {
            return this.Workflow.TryGetEvent(eventName, out _);
        }

    }

}