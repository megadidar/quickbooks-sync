﻿namespace QbSync.WebConnector
{
    public interface StepQueryResponse
    {
        /// <summary>
        /// Returns the step name.
        /// </summary>
        /// <returns>Step name.</returns>
        string GetName();

        /// <summary>
        /// Returns the string that has to be sent to the Web Connector.
        /// Return null if your step has nothing to do this time. The next step will be executed immediately.
        /// </summary>
        /// <param name="authenticatedTicket">The authenticated ticket.</param>
        /// <returns>QbXml or null to execute the next step.</returns>
        string SendXML(AuthenticatedTicket authenticatedTicket);

        /// <summary>
        /// Called when the Web Connector returns some data.
        /// </summary>
        /// <param name="authenticatedTicket">The authenticated ticket.</param>
        /// <param name="response">QbXml.</param>
        /// <param name="hresult">HResult.</param>
        /// <param name="message">Message.</param>
        /// <returns>Message to be returned to the Web Connector.</returns>
        int ReceiveXML(AuthenticatedTicket authenticatedTicket, string response, string hresult, string message);

        /// <summary>
        /// Called when the Web Connector detected an error.
        /// You can return a message to be displayed to the user.
        /// </summary>
        /// <param name="authenticatedTicket">The authenticated ticket.</param>
        /// <returns>Message to be displayed to the user.</returns> // TODO Confirm this?
        string LastError(AuthenticatedTicket authenticatedTicket);

        /// <summary>
        /// After receiving XML from the Web Connector, we check if we should move to the next step
        /// by calling this method. Usually, you want to move to the next step unless your step
        /// has other messages to send to the Web Connector. It is the case when you use an iterator.
        /// </summary>
        /// <returns>False stays on the current step. True goes to the next step.</returns>
        bool GotoNextStep();
    }
}
