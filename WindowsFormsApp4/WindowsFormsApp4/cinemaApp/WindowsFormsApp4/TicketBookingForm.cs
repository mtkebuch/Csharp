using System;

internal class TicketBookingForm
{
    private Movie selectedMovie;
    private int ticketQuantity;

    public TicketBookingForm(Movie selectedMovie)
    {
        this.selectedMovie = selectedMovie;
    }

    public TicketBookingForm(Movie selectedMovie, int ticketQuantity)
    {
        this.selectedMovie = selectedMovie;
        this.ticketQuantity = ticketQuantity;
    }

    internal void Show()
    {
        throw new NotImplementedException();
    }
}