const SearchBar = ({ searchTerm, setSearchTerm, handleSearch }) => {
  return (
    <div>
      <input
        type="text"
        placeholder="Search for book..."
        value={searchTerm}
        onChange={(e) => setSearchTerm(e.target.value)}
      />
      <button onClick={handleSearch}>Search</button>
    </div>
  );
};

export default SearchBar;
