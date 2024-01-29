import React, { useState } from "react";
import SearchBar from "./SearchBar";
import ResultsList from "./ResultsList";
import axios from "axios";
import "./SearchPage.css";

const SearchPage = () => {
  const [searchTerm, setSearchTerm] = useState("");
  const [results, setResults] = useState([]);

  const handleSearch = async () => {
    try {
      const response = await axios.get(
        `https://www.googleapis.com/books/v1/volumes?q=${searchTerm}`
      );
      setResults(response.data);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <div>
      <SearchBar
        searchTerm={searchTerm}
        setSearchTerm={setSearchTerm}
        handleSearch={handleSearch}
      />
      {results.items && <ResultsList results={results.items} />}
    </div>
  );
};

export default SearchPage;
