namespace Practice.Organization
{
    /// <summary>
    ///     Скрытая реализация представления об отделе предприятия.
    /// </summary>
    internal struct Department : IDepartment
    {
        public string Name { get; }
        
        /*
         * TODO #2: Реализуйте интерфейс IDepartment для структуры Department
         */
        public Department(string name)
        {
            Name = name;
        }
    }
}
