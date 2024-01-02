import React, { useState } from "react";
import SearchBar from "./SearchBar";
import ResultsList from "./ResultsList";
import axios from "axios";

const SearchPage = () => {
  const [searchTerm, setSearchTerm] = useState("");
  const [results, setResults] = useState([]);

  const handleSearch = async () => {
    try {
      const response = await axios.get(
        `https://www.googleapis.com/books/v1/volumes?q=${searchTerm}`
      );
      setResults(response.data.items);
    } catch (error) {
      console.warn(error);
    }
  };

  return (
    <div>
      <SearchBar
        searchTerm={searchTerm}
        setSearchTerm={setSearchTerm}
        handleSearch={handleSearch}
      />
      <ResultsList results={results} />
    </div>
  );
};

export default SearchPage;
