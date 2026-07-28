public class Doctor
{
    public const int MaximumDailyAppointments = 10;

    public string Id { get; }
    public string FullName { get; }
    public int AvailableSlots { get; private set; }
    public Doctor(string id, string fullName, int availableSlots)
    {
        if (string.IsNullOrWhiteSpace(id))
            throw new ArgumentException("Doctor ID is required.");
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Doctor name is required.");
        if (availableSlots < 0)
            throw new ArgumentException("Available slots cannot be negative.");
        if (availableSlots > MaximumDailyAppointments)
            throw new ArgumentException(
                $"A doctor cannot have more than {MaximumDailyAppointments} daily appointments.");
        Id = id;
        FullName = fullName;
        AvailableSlots = availableSlots;
    }
    public bool HasAvailableSlot()
    {
        return AvailableSlots > 0;
    }
    public void ReserveSlot()
    {
        if (!HasAvailableSlot())
            throw new InvalidOperationException("No appointment slots are available.");
        AvailableSlots--;
    }
}

